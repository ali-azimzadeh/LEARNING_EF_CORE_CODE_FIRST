
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DatabaseContext : System.Data.Entity.DbContext
    {
		public DatabaseContext() : base()
		{
		}

		//public DatabaseContext()
		//	: base(nameOrConnectionString: "MyDatabaseContext")
		//{
		//}

		//public DatabaseContext(string nameOrConnectionString)
		//	: base(nameOrConnectionString: nameOrConnectionString)
		//{
		//}

		public System.Data.Entity.DbSet<Person> People { get; set; }
	}
}
