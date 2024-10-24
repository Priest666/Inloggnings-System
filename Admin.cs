using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggning
{
    internal class Admin
    {
      
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

                        break;
                    case "2":

                        break;
                    case "3":
                        Console.WriteLine("Skriv vad du vill ändra consolefönstrets titel till");
                        string titel = Console.ReadLine();
                        Console.Title = titel;
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
