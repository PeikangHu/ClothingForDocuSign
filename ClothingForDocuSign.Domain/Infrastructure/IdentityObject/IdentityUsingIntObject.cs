using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingForDocuSign.Domain.Infrastructure.IdentityObject
{
	public abstract class IdentityUsingIntObject : IIdentityObject<int>
	{
		private readonly int _id;

		public IdentityUsingIntObject(int id)
		{
			_id = id;
		}

		/// <summary>
		/// Gets a unique ID. Equals and '==' are only based on ID.
		/// </summary>
		public int ID
		{
			get
			{
				return _id;
			}
		}

		/// <summary>
		/// Only based on ID.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			var p = obj as IdentityUsingIntObject;
			// Return true if the fields match:
			return ID == p.ID;
		}

		/// <summary>
		/// Only based on ID.
		/// </summary>
		/// <param name="identityUsingIntObject"></param>
		/// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
		public bool Equals(IdentityUsingIntObject identityUsingIntObject)
		{
			if (identityUsingIntObject == null)
			{
				return false;
			}
			return ID == identityUsingIntObject.ID;
		}

		/// <summary>
		/// Hash code is only based on ID.
		/// </summary>
		/// <returns>A hash code for the current object, which is ID.</returns>
		public override int GetHashCode()
		{
			return _id;
		}

		/// <summary>
		/// Only based on ID.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
		public static bool operator ==(IdentityUsingIntObject a, IdentityUsingIntObject b)
		{
			// If both are null, or both are same instance, return true.
			if (ReferenceEquals(a, b))
			{
				return true;
			}

			// If one is null, but not both, return false.
			if (((object)a == null) || ((object)b == null))
			{
				return false;
			}

			// Return true if the fields match:
			return a.ID == b.ID;
		}

		/// <summary>
		/// Only based on ID.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
		public static bool operator !=(IdentityUsingIntObject a, IdentityUsingIntObject b)
		{
			return !(a == b);
		}
	}
}
