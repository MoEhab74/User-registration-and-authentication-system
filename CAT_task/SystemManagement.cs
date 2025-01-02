namespace CAT_task
{
    internal class SystemManagement
    {
        public static void Register(string username, string email, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                throw new ArgumentNullException("Sorry, any field of user's fields can not be empty");
            // Check if we have the same email or username
            if (check_Email(email))
            {
                Console.WriteLine("Error: This email is already registered. Try another one.");
                return;
            }
            if (password.Length >= 8 && (password.Contains("@") || password.Contains("$") || password.Contains("*") || password.Contains("#")))
            {
                User user = new User(username, email, password);
                User.users.Add(user);
                Console.WriteLine("User has been registered successfuly");
            }
            else
                Console.WriteLine("Password should be greater than 8 characters and contains at least one special character like #,@,$,*, Try another one");


        }
        public static void Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                throw new ArgumentNullException("Sorry, all user fields are required");
            // Check if the user is exist or not
            if (check_Email(email))
            {
                Console.WriteLine("You have been logged in successuly, Welcome back");
            }
            else
            {
                Console.WriteLine("User not found");
            }

        }
        private static bool check_Email(string email)
        {
            bool found = false;
            for (int i = 0; i < User.users.Count; i++)
            {
                if (User.users[i].email == email)
                {
                    found = true;
                    return found;
                }
            }
            return found;
        }
        public static void ShowUsers()
        {
            if (User.users.Count == 0)
                Console.WriteLine("There aren't any users");
            else
            {
                foreach (var user in User.users)
                {
                    Console.WriteLine($"Email: {user.email}");
                }
            }
        }
        
    }
}
