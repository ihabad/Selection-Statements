using System;

namespace Selection_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // //Exercise 1:

            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("If you know my favorite number, then you really know me");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is two low!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is to high!");
            }
            else
            {
                Console.WriteLine($"Wow, You gussed it!");
            }


            //Exercise 2:

            Console.WriteLine("Hey! What is your favorite subject ?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case " Chemistry":
                    Console.WriteLine("I hate Chemistry!!");
                    break;
                case "Biomedical":
                    Console.WriteLine("I like biomedical research");
                    break;
                case " Fine Arts":
                    Console.WriteLine("Art is nice, especially fine arts ");
                    break;
                case "Economics":
                    Console.WriteLine("It is necessary to study economics ");
                    break;
                case "Math":
                    Console.WriteLine("The purpose of math is to solve problems ");
                    break;

                default:
                    Console.WriteLine("It's the first time I've heard of it!");
                    break;
            }
        }
    }
}
