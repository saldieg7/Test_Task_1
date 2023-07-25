using System;

namespace RandomPasswordTest
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomPasswordTest();
        }

        public static void RandomPasswordTest()
        {
            // Generate a random username 
            string username = "user" + new Random().Next(10000);
            string password;
            bool loggedIn = false;

            while (true)
            {
                // Ask for password
                Console.Write("Enter your password: ");
                password = Console.ReadLine();

                // Validate the password 
                if (password == "pwd" && !loggedIn)
                {
                    Console.WriteLine("Login successful.");
                    Console.WriteLine("Welcome !! " + " " + username);
                    loggedIn = true;
                }
                else if (!loggedIn)
                {
                    Console.WriteLine("Invalid password!! Please try again.");
                }

                if (loggedIn)
                {
                    //  log out
                    Console.Write("Type 'logout' to log out: ");
                    string logoutInput = Console.ReadLine();
                    if (logoutInput.ToLower() == "logout")
                    {
                        Console.WriteLine("Logged out successfully.");
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Logout failed.");
                    }
                }
            }
        }
    }
}




