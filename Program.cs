/*
If someone wanted to steal your information, they use each operation to make a guess at your password. 
With one high-performance computer and the right software, a 6 letter single-case password can be broken in one day.

In this project, I make a program that measures the strength of any given password based on the following criteria. 

The program will ask the user to input a password, and using conditional logic and control flow, it will rate the password.
*/

using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Start by defining password standards
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "!@#$%^&*()-+=_`~";

      // Capture input from the user
      Console.Write("Enter a password: ");
      string password = Console.ReadLine();

      // Score the user's password
      int len = password.Length;
      int score = 0;

      if (len >= minLength ) {
        score++;
      }
      if (Contains(password, uppercase)) {
        score++;
      }
      if (Contains(password, lowercase)) {
        score++;
      }
      if (Contains(password, digits)) {
        score++;
      }
      if (Contains(password, specialChars)) {
        score++;
      }  
      // Uncomment code below to test password score update
      // Console.WriteLine(score);

      // Let the user know how she did
      switch (score) 
      {
        case 5:
        case 4:
          Console.WriteLine("Password is extremely strong");
          break;
        case 3:
          Console.WriteLine("Password is strong");
          break;
        case 2:
          Console.WriteLine("Password is medium");
          break;
        case 1:
          Console.WriteLine("Password is weak");
          break;
        default:
          Console.WriteLine("Invalid Password");
          break;
      }
      Console.WriteLine(score);
    }

        public static bool Contains(string password, string uppercase)
        {
            return password.IndexOfAny(uppercase.ToCharArray()) != -1;
        }
    }
}
