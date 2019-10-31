using System;

namespace qanda
{
    class Program
    {
        static void Main(string[] args)
        {
            string start;
            string question1;
            string question2;
            string question3;

            Console.Clear();

            Console.WriteLine("                                                                        ");
            Console.WriteLine("                                                                        ");
            Console.WriteLine("Welcome, you'll get a few questions in a moment that you have to answer.");
            Console.WriteLine("                                                                        ");
            Console.WriteLine("                                                                        ");
            Console.WriteLine("                         PRESS ENTER TO START                           ");
            start = Console.ReadLine();
            Console.Clear();

            Console.Clear();

            Console.WriteLine("Did you ever get the chance to play Dying Light?");
            question1 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("If you did, did you enjoy it?");
            question2 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Would you play Dying Light 2, that's coming out soon?");
            question3 = Console.ReadLine();
            Console.Clear();

            Console.Clear();
            Console.WriteLine("Q: Did you ever get the chance to play Dying Light?");
            Console.Write("A: ");
            Console.Write(question1);
            Console.WriteLine(" ");
            Console.WriteLine("Q: If you did, did you enjoy it?");
            Console.Write("A: ");
            Console.Write(question2);
            Console.WriteLine(" ");
            Console.WriteLine("Q: Would you play Dying Light 2, that's coming out soon?");
            Console.Write("A: ");
            Console.Write(question3);
        }
    }
}
