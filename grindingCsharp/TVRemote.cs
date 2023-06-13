using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grindingCsharp
{
	class TVRemote
	{
		public static IElectronicDevice GetDevice()
		{
			return new Television();
		}
	}
}
