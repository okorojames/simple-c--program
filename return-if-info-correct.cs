using System;

class Program {
  static void Main(string[] args) {
    string username = "myusername";
    string password = "mypassword";
    
    Console.Write("Enter your username: ");
    string inputUsername = Console.ReadLine();
    
    Console.Write("Enter your password: ");
    string inputPassword = Console.ReadLine();
    
    if (inputUsername == username && inputPassword == password) {
      Console.WriteLine("Login successful!");
    } else {
      Console.WriteLine("Invalid username or password.");
    }
  }
}
// This code defines two variables for the correct username and password. It then prompts the user to enter their username and password using Console.ReadLine(). The code checks if the entered username and password match the correct values using an if statement. If the information is correct, it prints a success message using Console.WriteLine(). Otherwise, it prints an error message.





