using ClothingForDocuSign.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingForDocuSign
{
	public interface IClothingController
	{
		/// <summary>
		/// A view will call this function once the view receives the input.
		/// </summary>
		/// <param name="tempratureType">It might be null if the input is illegal.</param>
		/// <param name="commandIds">It might be null if the input is illegal.</param>
		/// <param name="exit">If a view sends an exit command, it will be true.</param>
		void OnInputFinished(TemperatureType? tempratureType, IList<int> commandIds, bool exit = false);

		/// <summary>
		/// Starts to listen users' inputs.
		/// </summary>
		void Start();
	}
}
