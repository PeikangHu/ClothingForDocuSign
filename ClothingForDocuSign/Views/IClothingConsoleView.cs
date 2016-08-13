using ClothingForDocuSign.Domain;
using ClothingForDocuSign.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingForDocuSign.ConsoleView.Views
{
	public interface IClothingConsoleView
	{
		/// <summary>
		/// Listens the result after the command run from the model.
		/// </summary>
		/// <param name="eventArgs">Contains which command it is and whether it runs successfully.</param>
		void CommandEventListener(ClothingCommandEventArgs eventArgs);

		/// <summary>
		/// Gets whether the command list will continue to run or be interrupted by the model or the user.
		/// </summary>
		bool IsFailed { get; }

		/// <summary>
		/// Prints out the result based on a command list.
		/// </summary>
		void ShowResult();

		/// <summary>
		/// Waits for the input from the user. Once the view receives the response, it will call the controller.
		/// </summary>
		void WaitForInput();
	}
}
