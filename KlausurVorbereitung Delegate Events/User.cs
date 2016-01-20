using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlausurVorbereitung_Delegate_Events
{
    class User
    {
        public string name;
        public int age;
        public int id;


        public void getUserInfo()
        {
            Console.WriteLine("id = {0}", id);
            Console.WriteLine("My Name is {0}",name);
            Console.WriteLine("I am {0} years old ", age);
            isOlderThan10();
            Console.WriteLine();
        }

        public void delegateTest()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("> DELEGATE TEST VON USER {0} <", name);
            Console.ResetColor();
            Console.WriteLine("");
        }

        public void isOlderThan10()
        {
            if(age > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} ist älter als 10", name);
                Console.ResetColor();
           
            }
        }

    }

}
