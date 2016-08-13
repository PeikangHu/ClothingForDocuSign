using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingForDocuSign.Domain
{
	public enum TemperatureType { HOT, COLD }

	// The standard even model requires a sender, but I do not want to expose the model to the view.
	public delegate void CommandRequest(ClothingCommandEventArgs eventArgs);

	public interface IClothingModel
	{
		event CommandRequest OnCommandRequest;

		/// <summary>
		/// If the id is executable, it will run this task and trigger an event called OnCommandRequest.
		/// Otherwise, it will only trigger the event and set CanContinue is false.
		/// </summary>
		/// <param name="id">The id of the command</param>
		void Next(int id);

		/// <summary>
		/// Reset all the statuses to the initial statuses.
		/// </summary>
		void Restart();
	}
}
