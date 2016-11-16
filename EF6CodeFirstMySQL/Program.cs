using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6CodeFirstMySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var entity = new ExampleDBContext())
            {
                User user = new User() { Name = "Adriano La Selva", Email = "adrianolaselva123@gmail.com" };

                user = entity.Users.Add(user);

                Console.WriteLine(user.Id);

                entity.SaveChanges();
            }
        }
    }
}
