using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingForDocuSign.Views
{
	public interface IInputAndOutput
	{
		/// <summary>
		/// Gets the input value.
		/// </summary>
		string InputValue { get; }

		/// <summary>
		/// Sets the output value.
		/// </summary>
		/// <param name="value">The value will be shown by the view.</param>
		void Output(string value);
	}
}
