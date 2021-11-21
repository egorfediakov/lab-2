using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {

            User user = new User();
            user.Login = "login";
            user.Name = "Name1";
            user.LastName = "LastName1";
            user.Age = 36;
            user.Info();
            Console.ReadKey();
        }
    }
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public readonly DateTime dateTime = new DateTime(2020, 12, 03);

        public void Info()
        {
            Console.WriteLine($"Login --- {Login}");
            Console.WriteLine($"Name --- {Name}");
            Console.WriteLine($"LastName --- {LastName}");
            Console.WriteLine($"Age --- {Age}");
            Console.WriteLine($"DateTime --- {dateTime}");
        }

    }
}
