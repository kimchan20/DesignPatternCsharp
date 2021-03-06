using Dapper.Model;
using Dapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Class
{
	class User : IUserRepository, ISearchRepository
	{
		List<UserModel> addList = new List<UserModel>();

		public void Add(object model)
		{
			addList.Add(model as UserModel);
		}

		public IEnumerable<UserModel> Filter(object model, IFilterRepository filter)
		{
			foreach(var item in addList)
				if(filter.isAge(item))
					yield return item;
		}

		public IEnumerable<UserModel> getUsers()
		{
			return addList;
		}
	}
}
