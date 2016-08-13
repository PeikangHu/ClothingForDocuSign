using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingForDocuSign.Domain.Infrastructure.ExecutionPlans
{
	/// <summary>
	/// Represents a strongly typed directional gragh that can run tasks flowing the direction.
	/// </summary>
	/// <typeparam name="T">Each object represents as a task.</typeparam>
	public interface IExecutionPlan<T>
	{
		/// <summary>
		/// Gets a read only dictionary of adjacency matrix for this execution plan.
		/// </summary>
		IReadOnlyDictionary<T, IList<T>> AdjacencyMatrix { get; }

		/// <summary>
		/// Gets a read only dictionary to show the in degree of each task.
		/// It will be never changed since the executionplan greated.
		/// Next(T task) will not affect the indegree. 
		/// </summary>
		IReadOnlyDictionary<T, int> TaskAndIndegree { get; }

		/// <summary>
		/// Run the task one by one and store the current status in the execution plan.
		/// </summary>
		/// <param name="task"></param>
		/// <returns>A boolean to show whether it runs successfully. If it runs wrong, the execution plan will automatically start over.</returns>
		bool Next(T task);

		/// <summary>
		/// Reset all the status to the initialize status.
		/// Once the execution plan starts over, Next(T task) will start from the first.
		/// </summary>
		void StartOver();
	}
}
