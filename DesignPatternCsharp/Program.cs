using DesignPatternCsharp.SolidPriciple;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCsharp
{
	class Program
	{
		private readonly static  UnitAdapter _unit = new UnitAdapter();

		
		/// <summary>
		/// this is main class 
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			//_unit.singleResponsibility.addEntry("hello");
			//_unit.singleResponsibility.addEntry("hi");
			//_unit.singleResponsibility.addEntry("hello 4");

			//Console.WriteLine(_unit.singleResponsibility.ToString());
			//_unit.singleResponsibility.removeEntry(2);

			//open close responsibility
			var item1 = new OpenCloseResponsibility.Product("House", ProductCategory.Size.large, ProductCategory.Color.red);
			var item2 = new OpenCloseResponsibility.Product("Ball", ProductCategory.Size.meium, ProductCategory.Color.green);
			var item3 = new OpenCloseResponsibility.Product("doll", ProductCategory.Size.small, ProductCategory.Color.blue);
			var item4 = new OpenCloseResponsibility.Product("tdoll", ProductCategory.Size.large, ProductCategory.Color.red);

			OpenCloseResponsibility.Product[] products = { item1, item2, item3, item4 };

			var filterSize = _unit.FilterProduct.FilterProductsBy(products,ProductCategory.Size.large);
			var filtercolor= _unit.FilterProduct.FilterProductsBy(products,ProductCategory.Color.green);
			var filterSizeandcolor = _unit.FilterProduct.FilterProductsBy(products,ProductCategory.Color.green,ProductCategory.Size.large);
			Console.WriteLine("-large");
			foreach(var item in filterSize)
			{
				Console.WriteLine(item._ProductName);
			}
			
			
			Console.WriteLine("\n**********");
			var filter = new Filter();
			var colorSpecs = new ColorSpec(ProductCategory.Color.blue);
			var sizeSpecs = new SizeSpec(ProductCategory.Size.large);
			//foreach(var item in filter.BetterFilter(products, new ColorSpec(ProductCategory.Color.blue)))
			//{
			//	Console.WriteLine(item._ProductName);
			//}


			foreach(var item in filter.BetterFilter(products, new Specification<OpenCloseResponsibility.Product>(colorSpecs,sizeSpecs)))
			{
				Console.WriteLine(item._ProductName);
			}

			Console.ReadLine();
		}
	}
}
