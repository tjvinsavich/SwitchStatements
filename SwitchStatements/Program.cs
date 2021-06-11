using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite school subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math huh? You must like numbers.");
                    break;
                case "english":
                    Console.WriteLine("English? Do they speak English in what?");
                    break;
                case "science":
                    Console.WriteLine("Science rules!");
                    break;
                case "history":
                    Console.WriteLine("*yawn* History? I never paid attention in that class," +
                        " so I had to repeat it.");
                    break;
                case "music":
                    Console.WriteLine("Music? You like Huey Lewis and the News?");
                    break;
                default:
                    Console.WriteLine("I'll take your word for it.");
                    break;
            }

        }
    }
}
