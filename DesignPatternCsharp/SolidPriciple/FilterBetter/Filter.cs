using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCsharp
{
	class Filter : IFilter<OpenCloseResponsibility.Product>
	{
		public IEnumerable<OpenCloseResponsibility.Product> BetterFilter(IEnumerable<OpenCloseResponsibility.Product> items, ISpecification<OpenCloseResponsibility.Product> category)
		{
			foreach(var item in items)
			{
				if(category.isStatisfied(item))
					yield return item;
			}
		}
	}

	class Specification<T> : ISpecification<T>
	{
		private ISpecification<T> first,second;
		public Specification(ISpecification<T> first,  ISpecification<T> second)
		{
			this.first = first;
			this.second = second;
		}

		public bool isStatisfied(T t)
		{
			return first.isStatisfied(t) && second.isStatisfied(t);
		}

	}
}
