//
//Programmer : Ivan Kim  Pasus
// Date Created : 03/04/2021 10:58:00 am
// Date Modified
// Program.cs

using Dapper.Class;
using Dapper.Class.ActionClass;
using Dapper.Model;
using Dapper.Repository;
using System;

namespace Dapper
{
	class Program
	{
		private static IAdapterRepository _unit = new Adapter();

	
		static void Main(string[] args)
		{
			test();
			Console.ReadLine();
		}

		public static void test()
		{
			_unit.user.Add(new UserModel{ age = 15,fname = "ivan" , lname = "kim"});
			_unit.user.Add(new UserModel{ age = 14,fname = "arisa" , lname = "chu"});
			_unit.user.Add(new UserModel{ age = 21,fname = "ivan" , lname = "kim"});
			_unit.user.Add(new UserModel{ age = 18,fname = "kim" , lname = "ivan"});

			//get user
			Console.WriteLine("\nUsers Unfilter");

			foreach(var item in _unit.user.getUsers())
			{
				Console.WriteLine(item.fname + " "  + item.lname + " - " +  item.age);
			}


			//filter age
			Console.WriteLine("\nUsers Filter : Adult");
			foreach(var item in _unit.user.Filter(_unit.user.getUsers(), new FilterUser(18)))
			{
				Console.WriteLine(item.fname + " "  + item.lname + " - " +  item.age + " an Adult : "+ new FilterUser(18).isAge(item).ToString() );
			}
		}
	}
}
