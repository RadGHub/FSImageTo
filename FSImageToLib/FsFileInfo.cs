using System;
using System.Collections.Generic;
using System.IO;
using MimeMapping;

namespace FSImageToLib
{
	public class FsFileInfo : FsInfo
	{
		public override string Type()
		{
			return "Файл";
		}

		
	}

}
