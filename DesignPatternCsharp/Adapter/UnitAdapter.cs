using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCsharp
{
	class UnitAdapter
	{
		public SingleResponsibility singleResponsibility { get;}

		public UnitAdapter()
		{
			singleResponsibility = new SingleResponsibility();
		}
	}
}
