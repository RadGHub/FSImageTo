using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MimeMapping;

namespace FSImageToLib
{
	public class FsDirectoryInfo :FsInfo
	{
		private List<FsInfo> fsInfos = new();
		public DirectoryInfo Directory { get; set; }
		public FsDirectoryInfo(DirectoryInfo directory)
		{
			Directory = directory;
		}
		public float GetSize()
		{
			long size = 0;
			List<FileInfo> files = Directory.GetFiles().ToList();
			foreach (var file in files)
			{
				size += file.Length;
			}
			return size;
		}

		public override string MimeType { get=>MimeType="";}

		public override string Type()
		{
			return "Папка";
		}

		public List<FsInfo> GetAllDirectoriesAndFiles()
		{
			fsInfos = Directory.GetAllEntities().ToFsInfo(Directory);
			return fsInfos;
		}
	}
}
