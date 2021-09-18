using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeMapping;

namespace FSImageToLib
{
	public static class Extentions
	{
		private static List<FileSystemInfo> list = new();
		private static List<FsInfo> fsinfos = new();

		public static List<FileSystemInfo> GetAllEntities(this DirectoryInfo directory)
		{
			List<FileInfo> files = directory.EnumerateFiles().ToList();
			List<DirectoryInfo> directories = directory.EnumerateDirectories().ToList();
			foreach (var file in files)
			{
				list.Add(new FileInfo(file.FullName));
			}
			foreach (var subdir in directories)
			{
				list.Add(new DirectoryInfo(subdir.FullName));
				GetAllEntities(subdir);
			}
			return list;

		}
		public static List<FsInfo> ToFsInfo(this List<FileSystemInfo> list, DirectoryInfo info)
		{
			foreach(var item in list)
			{
				if(item.GetType()==typeof(FileInfo))
				{
					fsinfos.Add(new FsFileInfo {Name=item.Name,Size=((FileInfo)item).Length,MimeType=MimeUtility.GetMimeMapping(item.Name) });
				}
				if (item.GetType() == typeof(DirectoryInfo))
				{
					fsinfos.Add(new FsDirectoryInfo(info) {Name=item.Name,Size=((DirectoryInfo)item).GetSize() });
				}
			}


			return fsinfos;
		}
		public static long GetSize(this DirectoryInfo directory)
		{
			long size = 0;
			IEnumerable<FileInfo> files = directory.EnumerateFiles();
			IEnumerable<DirectoryInfo> directories = directory.EnumerateDirectories();
			foreach (var file in files)
			{
				size += file.Length;
			}
			foreach (var dir in directories)
			{
				GetSize(dir);
			}

			return size;
		}
	}
}
