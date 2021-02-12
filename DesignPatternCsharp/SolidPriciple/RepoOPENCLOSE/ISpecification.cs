﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCsharp
{
	public interface ISpecification<T>
	{
		bool isStatisfied(T t);
	}
}
