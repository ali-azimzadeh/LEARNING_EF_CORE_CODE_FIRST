using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	/// <summary>
	/// POCO (Plain Old CLR Object) Class!
	/// </summary>
	public class Person : object
	{
		public Person() : base()
		{
		}

		/// <summary>
		/// Id, ID, PersonId, PersonID
		/// </summary>
		public int Id { get; set; }

		public int Age { get; set; }

		public string FullName { get; set; }

		public bool IsSupervisor { get; set; }
	}
}
