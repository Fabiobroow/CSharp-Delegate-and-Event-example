using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlausurVorbereitung_Delegate_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Delegate and Events");
            Console.WriteLine("");
            UserCheckEventClass uck = new UserCheckEventClass();

            User userOne = new User();
            userOne.id = 1;
            userOne.name = "Fabio";
            userOne.age = 5;

            User userTwo = new User();
            userTwo.id = 2;
            userTwo.name = "oibaf";
            userTwo.age = 11;

            User userThree = new User();
            userThree.id = 3;
            userThree.name = "bla";
            userThree.age = 15;

            User userFour = new User();
            userFour.id = 4;
            userFour.name = "rah";
            userFour.age = 3;

            // Mit Delegate möglich geht aber auch ohne !
            uck.UserInfoEvent += new UserInfoDelegate(userOne.getUserInfo);
            uck.UserInfoEvent += new UserInfoDelegate(userTwo.getUserInfo);

            //DELEGATE TEST
            uck.UserInfoEvent += userThree.delegateTest;
            //DELEGATE TEST ENDE

            uck.UserInfoEvent += userThree.getUserInfo;
            uck.UserInfoEvent += userFour.getUserInfo;

            uck.ShowUser();
            Console.ReadLine();
        }
    }
}
