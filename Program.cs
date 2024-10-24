namespace Inloggning
{
    internal class Program
    {
        static User user = new User();
        static List<User> users = new List<User>();

        static void Main(string[] args)
        {
            DefaultMenu();
        }

        public static void DefaultMenu()
        {
            int maxLoginAttempts = 10;
            Console.WriteLine("Välkommen! Fyll i ditt användarnamn: ");
            string username = Console.ReadLine();
            Console.WriteLine("Fyll i ditt lösenord");
            string password = Console.ReadLine();
            bool found = false;
            User foundUser = users.FirstOrDefault(x => x.Username == username && x.Password == password);
            for (int i = 0; i < maxLoginAttempts; i++)
            {
                if (username == "admin" && password == "1234")
                {
                    Admin admin = new Admin();
                    admin.AdminView();
                    found = true;
                    break;
                }
                if (foundUser != null)
                {
                    user.UserMenu();
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                Console.WriteLine("User does not exist");
            }
        }

        public static void CreateUser()
        {
            Console.Clear();
            Console.Write("Ange användarnamn: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Ange lösenord: ");
            string passWord = Console.ReadLine();
            users.Add(new User { Username = userName, Password = passWord });

            Console.WriteLine($"Användare {userName} har lagts till");

        }

    }


}
