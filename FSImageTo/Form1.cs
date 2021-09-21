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
		static string currentDir = Environment.CurrentDirectory;
		string inputMime = "";
		
		public Form1()
		{

			InitializeComponent();

		}

		private void ScanBtn_Click(object sender, EventArgs e)
		{
			DirectoryInfo df = new DirectoryInfo(currentDir);
			FsDirectoryInfo fsInfo = new FsDirectoryInfo(df);
			List<FsInfo> list = fsInfo.GetAllDirectoriesAndFiles();
			List<FsFileInfo> fileList = list.ToFsFileInfo();
			dataGridView1.Rows.Clear();

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
			labelCount.Text = $"Всего: {list.Count}";
			labelDirsCount.Text = $"Папок: {list.Count()-fileList.Count}";
			labelFileCount.Text = $"Файлов {fileList.Count}";

			comboBox.Items.AddRange(fileList.GetMimeTipes().ToArray());

		}

		private void SaveMenuItem_Click(object sender, EventArgs e)
		{
			DirectoryInfo df = new DirectoryInfo(currentDir);
			FsDirectoryInfo fsInfo = new FsDirectoryInfo(df);
			List<FsInfo> list = fsInfo.GetAllDirectoriesAndFiles();
			List<FsFileInfo> fileList = list.ToFsFileInfo();
			saveFileDialog1.Filter = "Html files (*.html)|*.html";
			if (saveFileDialog1.ShowDialog()==DialogResult.OK)
			{
				SaveToHtml saveTo = new SaveToHtml(list);
				saveTo.SaveHtmlDocument(saveFileDialog1.InitialDirectory, saveFileDialog1.FileName,
					list,fileList,inputMime);
			}
		}
		
		private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			DirectoryInfo df = new DirectoryInfo(currentDir);
			FsDirectoryInfo fsInfo = new FsDirectoryInfo(df);
			List<FsInfo> list = fsInfo.GetAllDirectoriesAndFiles();
			List<FsFileInfo> fileList = list.ToFsFileInfo();

			//переменные для оптимизации (чтоб не пересчитывать их заново для каждого label.text)
			int fileListCount = fileList.Count;
			inputMime = comboBox.SelectedItem.ToString();
			int countItemsInMime = fileList.CountMimeTypesInGroup(inputMime);
			string countItemsInMimePercent = (100/(float)fileListCount * countItemsInMime).ToString("#.##");
			string mediumSize = fileList.GetSize(inputMime).ToString("#.##");

			labelMimeName.Text = $"Mime тип - { inputMime}" ?? "Mime тип -";
			labelRelation.Text = $"Количество - {countItemsInMime} из {fileListCount} или {countItemsInMimePercent}%";
			labelMediumSize.Text = $"Средний размер - {mediumSize} b";
		}

		private void buttonOpen_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				
				currentDir = folderBrowserDialog1.SelectedPath;
			}
		}
	}
}
