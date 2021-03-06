using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Repository
{
	interface IUserRepository : ISearchRepository
	{
		void Add(object model);
	}
}
