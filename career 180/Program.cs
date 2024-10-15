using System;

class Program
{
    static string registeredUsername = "";
    static string registeredPassword = "";

    static void Main()
    {
        Console.WriteLine("Welcome to the User Login System!");

        Register();
        Login();
    }

    static void Register()
    {
        Console.WriteLine("\n--- Register ---");

        Console.Write("Enter a username: ");
        registeredUsername = Console.ReadLine();

        Console.Write("Enter a password: ");
        registeredPassword = Console.ReadLine();

        Console.WriteLine("Registration successful!");
    }

    static void Login()
    {
        Console.WriteLine("\n--- Login ---");

        Console.Write("Enter your username: ");
        string enteredUsername = Console.ReadLine();

        Console.Write("Enter your password: ");
        string enteredPassword = Console.ReadLine();

        if (enteredUsername == registeredUsername && enteredPassword == registeredPassword)
        {
            Console.WriteLine("Login successful! Welcome, " + registeredUsername + "!");
        }
        else
        {
            Console.WriteLine("Login failed! Incorrect username or password.");
        }
    }
}
