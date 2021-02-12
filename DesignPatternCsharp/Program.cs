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

		static void Main(string[] args)
		{
			_unit.singleResponsibility.addEntry("hello");
			_unit.singleResponsibility.addEntry("hello");

			Console.WriteLine(_unit.singleResponsibility.ToString());

			//var file = new SaveFile();

			//var filename = @"c:\Entries.txt";
			//file.SaveJournal(en, filename, true);

			Console.ReadLine();
		}
	}
}
