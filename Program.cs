using System;

namespace PrimativeTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Dotnet 101!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome to class, {name}!");
            Console.WriteLine("How old are you?");
            string strAge = Console.ReadLine();
            Int32.TryParse(strAge, out int age);
            System.Console.WriteLine($"In ten years {name} will be {age + 10}.");
            #region 
            /*
            var userInput = Console.Readline();
            This is my first application!
            */
            #endregion






            // int age = 24;
            // decimal bankAccount = 10.75m;
            // float sisterAge = 22f;
            //bool imTrue = true;
        }
    }
}
