using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggning
{
    internal class Admin
    {
        static List<User> users = new List<User>();
        public void AdminView()
       {
            bool runProgram = true;

            while (runProgram)
            {
                Console.WriteLine("Gör ett val.\n");
                Console.WriteLine("1. Skapa användare");
                Console.WriteLine("2. Byt slumpmässig färg");
                Console.WriteLine("3. Ändra titel");
                Console.WriteLine("4. Avsluta");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateUser();
                        break;
                    case "2":
                        Random randomColor = new Random();
                        Console.ForegroundColor = (ConsoleColor)randomColor.Next((int)ConsoleColor.DarkBlue, (int)ConsoleColor.White);
                        break;
                    case "3":
                        Console.WriteLine("Skriv vad du vill ändra consolefönstrets titel till");
                        string titel = Console.ReadLine();
                        Console.Title = titel;
                        break;

                    case "4":
                        Program.DefaultMenu();
                        runProgram = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
       }

       public static void CreateUser()
       {
            Console.Clear();
            Console.Write("Ange användarnamn: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Ange lösenord: ");
            string passWord = Console.ReadLine();
            users.Add(new User{ Username = userName, Password = passWord });

            Console.WriteLine($"Användare {userName} har lagts till");

       }




    }
}
