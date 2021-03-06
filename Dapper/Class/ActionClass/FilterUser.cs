using Dapper.Model;
using Dapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Class.ActionClass
{
	class FilterUser : IFilterRepository
	{
		private const int _ageLimit = 18;
		public bool isAge(object model)
		{
			var modelcon = model as UserModel;
			return modelcon.age > _ageLimit;
		}
	}
}
