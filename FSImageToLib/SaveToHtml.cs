using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FSImageToLib
{
	public class SaveToHtml
	{
		public string ToHtml()
		{
			return "";
		}
		public async void Write()
		{
			using (StreamWriter writer = File.CreateText("index.html"))
			{
				await writer.WriteAsync(ToHtml());
			}
		}
	}
}
