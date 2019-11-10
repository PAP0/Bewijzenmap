using System;

namespace canyoudrive
{
    class Program
    {
        static void Main (string[] args)
        {

        // Vraag 1 //
        Console.Clear();

        String a;
        Console.WriteLine("=====================");
        Console.WriteLine("Hoe oud ben je?");
        Console.WriteLine("=====================");
        Console.WriteLine("");
        Console.WriteLine("Voer een nummer in.");
        a = Console.ReadLine();
        int age = Int32.Parse(a);

        if (age >= 18)
            {
                Console.WriteLine("Mogge Ouwe.");
            }
            else if (age == 17)
            {
                Console.WriteLine("Nog ff en je mag alleen wegrijden.");
            }
            else if (age == 16)
            {
                Console.WriteLine("Je scooter wacht op je.");
            }
            else if (age <= 16)
            {
                Console.WriteLine("Wacht nog maar ff.");
            }
            else
            {
                Console.WriteLine("Why You Bully Me?!");
            }
            Console.WriteLine("press any button to continue");
            Console.ReadKey(true);

            Console.Clear();

        // Vraag 2 //

        string b;
        Console.WriteLine("=========================");
        Console.WriteLine("Heb je al een rijbewijs??");
        Console.WriteLine("=========================");
        Console.WriteLine("");
        Console.WriteLine("Ja of Nee?");
        b = Console.ReadLine();

        if (b == "Ja" || b == "ja")
            {
                Console.WriteLine("Lekker Bezig, Pik.");
            }
            else if (b == "nee" || b == "Nee")
            {
                Console.WriteLine("Lekker rustig aan.");

            }
            else
            {
                Console.WriteLine("Why You Bully Me?!");
            }
            Console.WriteLine("press any button to continue");
            Console.ReadKey(true);

            Console.Clear();  

        // Antwoorden Overzicht //
        
            Console.WriteLine("=============================");
            Console.WriteLine("Your Answers were:");
            Console.WriteLine("");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("");
            Console.WriteLine("=============================");
            Console.WriteLine("");

        // Rijbewijs: Ja //

        if (age >= 18 && b == "Ja" || b == "ja")
            {
            Console.WriteLine("Moet ik je echt vertellen wat je wel of niet mag doen?");
            Console.WriteLine("");
            Console.WriteLine("Lessen: Ja.");
            Console.WriteLine("Auto: Ja.");
            Console.WriteLine("Scooter: Ja.");
            Console.WriteLine("");
            }
            else if (age == 17 && b == "Ja" || b == "ja")
            {
            Console.WriteLine("Je Bent er bijna.");
            Console.WriteLine("");
            Console.WriteLine("Lessen: Ja.");
            Console.WriteLine("Auto: Ja, maar niet alleen.");
            Console.WriteLine("Scooter: Ja.");
            Console.WriteLine("");
            }
            else if (age >= 16 && b == "Ja" || b == "ja")
            {
            Console.WriteLine("Nog ff wachten voor de auto.");
            Console.WriteLine("");
            Console.WriteLine("Lessen: Alleen voor scooter.");
            Console.WriteLine("Auto: Nee.");
            Console.WriteLine("Scooter: Ja.");
            Console.WriteLine("");
            }

        // Rijbewijs: Nee //

            else if (age >= 18 && b == "Nee" || b == "nee")
            {
            Console.WriteLine("Nog geen Rijbewijs? Boeie Ruud.");
            Console.WriteLine("");
            Console.WriteLine("Lessen: Ja");
            Console.WriteLine("Auto: Ja, maarmet een rijbewijs natuurlijk.");
            Console.WriteLine("Scooter: Ja, maar met een rijbewijs natuurlijk.");
            Console.WriteLine("");
            }
             else if (age == 17 && b == "Nee" || b == "nee")
            {
            Console.WriteLine("Nog geen Rijbewijs? Komt wel goed hoor, Henk.");
            Console.WriteLine("");
            Console.WriteLine("Lessen: Ja.");
            Console.WriteLine("Auto: Ja, maar niet alleen & met een rijbewijs natuurlijk.");
            Console.WriteLine("Scooter: Ja, maar met een rijbewijs natuurlijk.");
            Console.WriteLine("");
            }
             else if (age == 16 && b == "Nee" || b == "nee")
            {
            Console.WriteLine("Nog geen Rijbewijs? Rustaaagh, je bent nog jong zat.");
            Console.WriteLine("");
            Console.WriteLine("Lessen: Alleen voor scooter.");
            Console.WriteLine("Auto: Nee.");
            Console.WriteLine("Scooter: Ja, maar met een rijbewijs natuurlijk.");
            Console.WriteLine("");
            }
            
        // Anders //

            else
            {
            Console.WriteLine("Waarom doe je uberhaupt mee? ");
            Console.WriteLine("");
            Console.WriteLine("Lessen: Nee.");
            Console.WriteLine("Auto: Nee.");
            Console.WriteLine("Scooter: Nee.");
            Console.WriteLine("");
            }
        }
    }
}
    