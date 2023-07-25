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
            string username;
            string password;
            bool loggedIn = false;

            while (true)
            {
                // Keep asking for username until a valid value is provided
                do
                {
                    Console.Write("Enter your username: ");
                    username = Console.ReadLine();

                    // Check if the username is empty or null
                    if (string.IsNullOrEmpty(username))
                    {
                        Console.WriteLine("Invalid username. Please try again.");
                    }
                    else
                    {
                        // Reset the loggedIn flag if the user enters a new username
                        loggedIn = false;
                    }
                } while (string.IsNullOrEmpty(username));

                // Ask for password
                Console.Write("Enter your password: ");
                password = Console.ReadLine();

                // Validate the password (you can replace this with your own validation logic)
                if (password == "pwd" && !loggedIn)
                {
                    Console.WriteLine("Login successful.");
                    Console.WriteLine("Welcome !!! "+" "+username);
                    loggedIn = true;
                }
                else if (!loggedIn)
                {
                    Console.WriteLine("Invalid username or password. Please try again.");
                }

                if (loggedIn)
                {
                    // Ask to log out
                    Console.Write("Type 'logout' to log out: ");
                    string logoutInput = Console.ReadLine();
                    if (logoutInput.ToLower() == "logout")
                    {
                        Console.WriteLine("Logged out successfully.");
                        break; // Exit the loop and end the test
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



