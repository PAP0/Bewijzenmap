using System;

namespace whatsmyname
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            string eyecolor;
            string postalcode;
            string residence;
            string start;

            Console.Clear();

            Console.WriteLine("###########################################################");
            Console.WriteLine("###########################################################");
            Console.WriteLine("#######################  HACKERMAN  #######################");
            Console.WriteLine("#######################    9000     #######################");
            Console.WriteLine("###########################################################");
            Console.WriteLine("###########################################################");
            Console.WriteLine("###########################################################");
            Console.WriteLine("                                                           ");
            Console.WriteLine("                   PRESS ENTER TO PROCEED                  ");
            start = Console.ReadLine();
            Console.Clear();

            Console.Clear();

            Console.WriteLine("What's your name?");
            name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("And what's your age?");
            age = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("How about your eye color?");
            eyecolor = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Your postal code?");
            postalcode = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("And where do you reside?");
            residence = Console.ReadLine();
            Console.Clear();

            Console.Clear();

            Console.WriteLine("I've hacked your computer and have gotten all of your information. Your name is {0}, your age is {1}, you have {2} eyes.", name, age, eyecolor);
            Console.WriteLine("you live in {0} and your postal code is {1}. What are you gonna do now huh?", residence, postalcode);

        }
    }
}
