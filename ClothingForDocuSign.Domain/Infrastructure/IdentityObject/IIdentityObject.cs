using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingForDocuSign.Domain.Infrastructure.IdentityObject
{
	public interface IIdentityObject<T>
	{
		/// <summary>
		/// Gets a strongly typed Id.
		/// </summary>
		T ID { get; }
	}
}
