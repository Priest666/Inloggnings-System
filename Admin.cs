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
                        Random randomColor = new Random();
                        Console.ForegroundColor = (ConsoleColor)randomColor.Next((int)ConsoleColor.Black, (int)ConsoleColor.White);
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



    }
}
