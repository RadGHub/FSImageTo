using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSImageToLib;
using MimeMapping;

namespace FSImageTo
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}

		private void ScanBtn_Click(object sender, EventArgs e)
		{
			List<FsInfo> list = InitListOfAllEntities();
			foreach (var entity in list)
			{
				if (entity.GetType() == typeof(FsFileInfo))
				{
					dataGridView1.Rows.Add(entity.Type(), entity.Name, entity.Size + " b", entity.MimeType);
				}
				else if (entity.GetType() == typeof(FsDirectoryInfo))
				{
					dataGridView1.Rows.Add(entity.Type(), entity.Name, entity.Size + " b");
				}
			}
		}

		private static List<FsInfo> InitListOfAllEntities()
		{
			string currentDir = "C:\\Users\\arche\\source\\repos\\TestDirectories\\1";
			DirectoryInfo df = new DirectoryInfo(currentDir);
			FsDirectoryInfo fsInfo = new FsDirectoryInfo(df);
			List<FsInfo> list = fsInfo.GetAllDirectoriesAndFiles();
			return list;
		}

		private void SaveMenuItem_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "Html files (*.html)|*.html";
			if (saveFileDialog1.ShowDialog()==DialogResult.OK)
			{
				SaveToHtml saveTo = new SaveToHtml(InitListOfAllEntities());
				saveTo.SaveHtmlDocument(saveFileDialog1.InitialDirectory, saveFileDialog1.FileName);
			}
		}
	}
}
