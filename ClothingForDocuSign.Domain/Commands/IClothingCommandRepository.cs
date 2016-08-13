using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingForDocuSign.Domain.Commands
{
	public interface IClothingCommandRepository
	{
		/// <summary>
		/// Gets all the commands
		/// </summary>
		IReadOnlyCollection<IClothingCommand> ClothingCommands { get; }

		/// <summary>
		/// Gets a command by ID
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		IClothingCommand Get(int id);
	}
}
