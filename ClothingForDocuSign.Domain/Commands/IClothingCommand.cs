using ClothingForDocuSign.Domain.Infrastructure.IdentityObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingForDocuSign.Domain.Commands
{
	
	public interface IClothingCommand : IIdentityObject<int>
	{
		/// <summary>
		/// Gets the description of the Command.
		/// </summary>
		string Description { get; }

		/// <summary>
		/// Gets the response based on the temperature type
		/// </summary>
		/// <param name="temperatureType"></param>
		/// <returns></returns>
		string Response(TemperatureType temperatureType);
	}
}
