using Dapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Class
{
	class Adapter : IAdapterRepository
	{
		public IUserRepository user { get; }

		public ISearchRepository userRepo { get; }

		public Adapter()
		{
			user = new User();
			userRepo = userRepo;
		}

		public void Dispose()
		{
			if (this != null)
				GC.SuppressFinalize(this);
		}

		//public void Dispose()
		//{
		//	if(this != null)
		//		GC.SuppressFinalize(this);
		//}
	}
}
