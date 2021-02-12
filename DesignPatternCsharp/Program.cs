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
		private readonly static UnitAdapter _unit = new UnitAdapter();


		/// <summary>
		/// this is main class 
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			_unit.singleResponsibility.addEntry("hello");
			_unit.singleResponsibility.addEntry("hello");

			Console.WriteLine(_unit.singleResponsibility.ToString());

			Console.ReadLine();
		}
	}
}
