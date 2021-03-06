using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCsharp
{
	public class SingleResponsibility
	{

		private readonly Dictionary<int, string> entries = new Dictionary<int, string>();

		public bool addEntry(string message)
		{
			entries.Add(entries.Count + 1, message);
			return true;
		}

		public bool removeEntry(int entNumber)
		{
			return entries.Remove(entNumber);
		}

		public Dictionary<int, string> GetEntries()
		{
			return entries;
		}

		public int countEnt()
		{
			return entries.Count();
		}

		public override string ToString()
		{
			return string.Join(Environment.NewLine, entries);
		}
	}


	class SaveEntry
	{
		public bool SaveEnties(string filename, SingleResponsibility single,bool overwrite = false)
		{
			if(overwrite || File.Exists(filename))
				File.WriteAllText(filename,single.ToString());

			return true;
		}
	}
}
