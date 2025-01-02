namespace CAT_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome to our system");
            do
            {
                Console.Write("Get started with us   ===>   Register now || Login: ");
                var choise = Console.ReadLine().ToUpper()[0];
                //SystemManagement systemManagement = new SystemManagement();

                switch (choise)
                {
                    case 'R':
                        // Add logic
                        Console.Write("Enter your username: ");
                        var username = Console.ReadLine();
                        Console.Write("Enter your email: ");
                        var email = Console.ReadLine();
                        Console.Write("Enter your password: ");
                        var password = Console.ReadLine();
                        SystemManagement.Register(username, email, password);

                        break;
                    case 'L':
                        // Add logic
                        Console.Write("Enter your email: ");
                        email = Console.ReadLine();
                        Console.Write("Enter your password: ");
                        password = Console.ReadLine();
                        SystemManagement.Login(email, password);
                        break;
                }
            } while (true);
            
        }
    }
}
