using System;

namespace opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandAttack = "attack";
            string commandDefend = "defend";
            string commandMagic = "magic";

            byte playerHealth = 100;

            bool gameOver = false;

            byte playermaxHealth = 100;

            byte monstermaxHealth = 250;

            string monsterName = "THE YEETER";

            bool playerRun = false;
            string commandRunaway = "runaway";

            int screenWidth = 75;
            int screenHeight = 25;

            Console.SetWindowSize(screenWidth, screenHeight);
            Console.SetBufferSize(screenWidth, screenHeight);

            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("0000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            Console.WriteLine("00000   YEE      YEE        YEETYEETYEET    YEETYEETYEET    YEETYEETYEET   0000000");
            Console.WriteLine("00000   YEE      YEE        YE              YE                   YE        0000000");
            Console.WriteLine("00000    YE      YE000000000YE00000000000000YE0000000000000000000YE        0000000");
            Console.WriteLine("00000     YE    YE0000000000YE00000000000000YE0000000000000000000YE        0000000");
            Console.WriteLine("00000000000YE  YE00000000000YEETYEE000000000YEETYEE00000000000000YE        0000000");
            Console.WriteLine("0000000000000YE0000000000000YE00000000000000YE0000000000000000000YE        0000000");
            Console.WriteLine("0000000000000YE0000000000000YE00000000000000YE0000000000000000000YE        0000000");
            Console.WriteLine("0000000000000YE0000000000000YE00000000000000YE0000000000000000000YE        0000000");
            Console.WriteLine("0000000000000YE0000000000000YEETYEETYEET0000YEETYEETYEET000000000YE        0000000");
            Console.WriteLine("0000000000000000000000000000000000000000000000000000000000000000000000000000000000");



            Console.CursorTop = 15;
            Console.CursorLeft = 10;
            Console.Write("The text begins from here");

            Console.Write("Player Health: " + playerHealth + "HP \n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Type to take action");
            Console.WriteLine("[" +commandAttack + "]" + "[" +commandDefend + "]" + "[" +commandMagic + "]");

            Console.CursorTop = 15;
            Console.CursorLeft = 10;
            Console.WriteLine("Type command to continue");


            Console.ReadLine();

            Console.ResetColor();

            Console.Clear();
            Console.WriteLine("YEET TO QUIT");
            Console.ReadKey(true);

        }
    }
}
