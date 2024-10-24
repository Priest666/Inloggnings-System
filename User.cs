using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inloggning
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public void UserMenu()
        {
            System.Timers.Timer timer = new(interval: 120000);
            timer.Elapsed += (sender, e) => HandleTimer();
            timer.Start();
            void HandleTimer() { timer.Stop(); Program.DefaultMenu(); }
            Console.WriteLine("Vänligen gör ett val: \n1. Avsluta \n2. Visa ditt lösenord");
            string choose = Console.ReadLine();

            if (choose == "1")
            {
                return;
            }
            else if (choose == "2")
            {
                Console.WriteLine($"Ditt lösenord är: ");
            }
            else
            {
                Console.WriteLine("Ogiltigt val");
            }


        }
    }
}
