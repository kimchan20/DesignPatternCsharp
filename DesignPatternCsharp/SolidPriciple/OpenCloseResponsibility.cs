using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCsharp
{
	public class OpenCloseResponsibility
	{
		public class Product
		{
			public string _ProductName { get; set; }
			public ProductCategory.Size _size;
			public ProductCategory.Color _color;
			public Product()
			{

			}
			public Product(string ProductName, ProductCategory.Size size, ProductCategory.Color color)
			{
				_ProductName = ProductName;
				_size = size;
				_color = color;
			}
		}
	}


	public class FilterProduct
	{
		public IEnumerable<OpenCloseResponsibility.Product> FilterProductsBy(IEnumerable<OpenCloseResponsibility.Product> products
			, ProductCategory.Size size)
		{
			foreach (var item in products)
				if (item._size == size)
					yield return item;
		}

		public IEnumerable<OpenCloseResponsibility.Product> FilterProductsBy(IEnumerable<OpenCloseResponsibility.Product> products
			, ProductCategory.Color color)
		{
			foreach (var item in products)
				if (item._color == color)
					yield return item;
		}

		public IEnumerable<OpenCloseResponsibility.Product> FilterProductsBy(IEnumerable<OpenCloseResponsibility.Product> products
			, ProductCategory.Color color, ProductCategory.Size size)
		{
			foreach (var item in products)
				if (item._color == color || item._size == size)
					yield return item;
		}

	}



}
