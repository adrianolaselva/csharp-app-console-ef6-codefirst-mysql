using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6CodeFirstMySQL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ExampleDBContext : DbContext
    {
        public ExampleDBContext() : base("name=MyContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<User>().MapToStoredProcedures();
        }

        public DbSet<User> Users { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
    }
}
