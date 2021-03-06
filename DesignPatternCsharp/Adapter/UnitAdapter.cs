using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCsharp
{
	public class UnitAdapter
	{
		public SingleResponsibility singleResponsibility { get;}
		public FilterProduct FilterProduct { get;}
		public OpenCloseResponsibility.Product Open{get;}
		public UnitAdapter()
		{
			singleResponsibility = new SingleResponsibility();
			FilterProduct = new FilterProduct();
			Open = new OpenCloseResponsibility.Product();
		}
	}
}
