using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCsharp.SolidPriciple
{
	class ColorSpec : ISpecification<OpenCloseResponsibility.Product>
	{
		private readonly ProductCategory.Color color;
		public ColorSpec(ProductCategory.Color _color)
		{
			color = _color;
		}
		public bool isStatisfied(OpenCloseResponsibility.Product t)
		{
			return t._color == color;
		}
	}
}
