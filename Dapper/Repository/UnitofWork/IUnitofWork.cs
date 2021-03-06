using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Repository.UnitofWork
{
	interface IUnitofWork<T> : IDisposable
	{
		dynamic Insert(T model);
	}
}
