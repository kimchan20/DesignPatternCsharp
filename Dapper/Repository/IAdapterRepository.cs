using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Repository
{
	interface IAdapterRepository : IDisposable
	{
		IUserRepository user { get; }
		ISearchRepository userRepo { get; }

	

	}
}
