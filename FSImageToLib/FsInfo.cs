using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSImageToLib
{
	public class FsInfo
	{

		public virtual string Name { get; set; }
		public virtual long Size { get; set; }

		public virtual string MimeType{ get; set; }

		public virtual string Type()
		{
			return "Общий";
		}

	}
}
