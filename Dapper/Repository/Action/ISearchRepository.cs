using Dapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Repository
{
	interface ISearchRepository 
	{


		IEnumerable<UserModel> getUsers();

		IEnumerable<UserModel> Filter(object model, IFilterRepository filter);
	}
}
