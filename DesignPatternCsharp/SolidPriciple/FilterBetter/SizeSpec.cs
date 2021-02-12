using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCsharp.SolidPriciple
{
	class SizeSpec : ISpecification<OpenCloseResponsibility.Product>
	{
		private readonly ProductCategory.Size size;
		public SizeSpec(ProductCategory.Size _size)
		{
			size = _size;
		}

		public bool isStatisfied(OpenCloseResponsibility.Product t)
		{
			return size == t._size;
		}
	}
}
