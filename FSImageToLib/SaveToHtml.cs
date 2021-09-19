using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Aspose.Html;
using Aspose.Html.Converters;
using Aspose.Html.Saving;

namespace FSImageToLib
{
	public class SaveToHtml
	{
		public List<FsInfo> DataList { get; set; }
		public SaveToHtml(List<FsInfo> info)
		{
			DataList = info;
		}
		public void SaveHtmlDocument(string outputDir, string documentName)
		{
			string documentPath = Path.Combine(outputDir,documentName);

			using (var document = new HTMLDocument())
			{
				string bootstrapHead = string.Format("<head><link href = \"https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css\" rel = \"stylesheet\" integrity = \"sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x\" crossorigin = \"anonymous\"></head>");

				var body = document.Body;
				var link = document.CreateElement("link") as HTMLLinkElement;
				link.Href = "https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css";
				link.Rel = "stylesheet";
				document.Body.AppendChild(link);

				var table = document.CreateElement("table") as HTMLTableElement;
				table.ClassName = "table table-dark table-striped";
				var thead = document.CreateElement("thead") as HTMLTableSectionElement;
				for (int i = 0; i < 1; i++)
				{
					var row = document.CreateElement("tr") as HTMLTableRowElement;
					HTMLTableCellElement typeCell = CreateTheadCell(document, "Type");
					row.AppendChild(typeCell);
					HTMLTableCellElement nameCell = CreateTheadCell(document, "Name");
					row.AppendChild(nameCell);
					HTMLTableCellElement sizeCell = CreateTheadCell(document, "Size");
					row.AppendChild(sizeCell);
					HTMLTableCellElement mimeCell = CreateTheadCell(document, "Mime");
					row.AppendChild(mimeCell);
					thead.AppendChild(row);
				}
				var tbody = document.CreateElement("tbody") as HTMLTableSectionElement;
				for (int i=0;i<DataList.Count;i++)
				{
					var row = document.CreateElement("tr") as HTMLTableRowElement;
					row.Id = "trow_" + i;
					//
					var typecell = document.CreateElement("td") as HTMLTableCellElement;
					typecell.TextContent = DataList[i].Type();
					row.AppendChild(typecell);
					var nameCell = document.CreateElement("td") as HTMLTableCellElement;
					nameCell.TextContent = DataList[i].Name;
					row.AppendChild(nameCell);
					var sizeCell = document.CreateElement("td") as HTMLTableCellElement;
					sizeCell.TextContent = DataList[i].Size.ToString();
					row.AppendChild(sizeCell);
					var mimeCell = document.CreateElement("td") as HTMLTableCellElement;
					mimeCell.TextContent = DataList[i].MimeType;
					row.AppendChild(mimeCell);
					//
					tbody.AppendChild(row);
				}
				table.AppendChild(thead);
				table.AppendChild(tbody);
				document.Body.AppendChild(table);

				document.Save(documentPath);
			}
		}

		private static HTMLTableCellElement CreateTheadCell(HTMLDocument document, string name)
		{
			var cell = document.CreateElement("th") as HTMLTableCellElement;
			cell.Id = $"th_{name.ToLower()}";
			cell.TextContent = name;
			return cell;
		}
	}
}
