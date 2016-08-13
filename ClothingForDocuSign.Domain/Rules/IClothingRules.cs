using ClothingForDocuSign.Domain.Commands;
using ClothingForDocuSign.Domain.Infrastructure.ExecutionPlans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingForDocuSign.Domain.Rules
{
	public interface IClothingRules
	{
		/// <summary>
		/// Gets an execution plan to represent the wearing sequence.
		/// </summary>
		IExecutionPlan<IClothingCommand> Rules { get; }
	}
}
