using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCsharp
{
	public interface IFilter<T>
	{
		IEnumerable<T> BetterFilter (IEnumerable<T> items ,ISpecification<T> category);
	}
}
