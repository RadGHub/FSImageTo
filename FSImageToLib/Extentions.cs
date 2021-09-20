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
		public static List<FsFileInfo> ToFsFileInfo(this List<FsInfo> list)
		{
			List<FsFileInfo> fsFileList = new();
			foreach (var item in list)
			{
				if(item.GetType()==typeof(FsFileInfo))
				{
					fsFileList.Add(new FsFileInfo { Name = item.Name, Size = ((FsFileInfo)item).Size, MimeType = MimeUtility.GetMimeMapping(item.Name) });
				}
			}

			return fsFileList;
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
		public static List<string> GetMimeTipes(this List<FsFileInfo> list)
		{
			List<string> uniqMimeList = list.Select(item => item.MimeType).Distinct().ToList();
			return uniqMimeList;
		}
		public static int CountMimeTypesInGroup(this List<FsFileInfo> list, string inputMime)
		{
			int count = 0;
			List<string> mimeTypes = list.Select(x=>x.MimeType).ToList();

			var mimesGroups = mimeTypes.GroupBy(g=>g);
			foreach(var item in mimesGroups)
			{
				if(inputMime==item.Key)
				{
					count = item.Count();
					return count;
				}
				else
				{
					count = 0;
				}
			}
			return count;
		}
		public static long GetSize(this List<FsFileInfo> list, string inputMime)
		{
			long listSize = 0;
			long mediumSize = 0;
			var mimesGroups = list.GroupBy(g => g.MimeType);
			
			foreach(var group in mimesGroups)
			{
				if (inputMime == group.Key)
				{
					foreach (var item in group)
					{
						listSize += item.Size;
					}
					mediumSize = listSize / group.Count();
				}
			}
			return mediumSize;
		}
	}
}
