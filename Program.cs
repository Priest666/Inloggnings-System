﻿namespace Inloggning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine("Välkommen! Fyll i ditt användarnamn:");
            string username = Console.ReadLine();
            Console.WriteLine("Fyll i ditt lösenord");
            string password = Console.ReadLine();

            if (username == "admin" && password == "1234")
            {
                Admin admin = new Admin();
                admin.AdminView();
                
            } else if u
            
        }
    }
}
