using CodeBlogFitness.BL.Controller;
using System;

namespace CodeBlogFitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the application CodeBlogFitness");

            Console.WriteLine("Entr user name");
            var name = Console.ReadLine();

            Console.WriteLine("Enter gender");
            var gender = Console.ReadLine();

            Console.WriteLine("Enter birthday");
            var birthdate = DateTime.Parse(Console.ReadLine()); //TODO

            Console.WriteLine("Enter weight");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthdate, weight, height);
            userController.Save();
        }
    }
}
