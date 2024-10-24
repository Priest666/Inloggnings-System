using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggning
{
    internal class Admin
    {
        List<User> users = new List<User>();

        public void AdminView()
       {
            Console.WriteLine("Gör ett val.\n");
            Console.WriteLine("1. Skapa användare");
            Console.WriteLine("2. Byt slumpmässig färg");
            Console.WriteLine("3. Ändra titel");
            Console.WriteLine("4. Avsluta");

            bool runProgram = true;

            while (runProgram)
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":

                        break;

                    case "4":
                        runProgram = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
       }

       public void CreateUser()
       {
            Console.Clear();
            Console.Write("Ange användarnamn: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Ange lösenord: ");
            string passWord = Console.ReadLine();
            users.Add(new User());

            

       }




    }
}
