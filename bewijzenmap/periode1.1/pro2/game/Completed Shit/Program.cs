﻿using System;

namespace _Eindresultaat
{
    class Program
    {

        // ------------------ ROCK/PAPER/SCISSORS RPG ------------------
        static void Main(string[] args)
        {

            bool isGameRunning = true;

            Random randomNum = new Random();

            int screenWidth = 75;
            int screenHeight = 25;


            // COMMAND VARIABLES:
            string message = "";

            string commandAttack = "attack";
            string commandDefend = "defend";
            string commandMagic = "magic";
            string commandRun = "run";


            // PLAYER VARIABLES:
            int playerHealth = 100;
            int playerHealthMax = 100;
            int playerAttack = 10;
            int playerWins = 0;
            int playerWinsEnd = 5;
            int playerRunSetback = 1;
            bool playerRunAway = false;
            bool gameOver = false;

            int healthRestoreMin = 1;
            int healthRestoreMax = 25;


            // MONSTER VARIABLES:
            int monsterHealth = -1;    // Init during battle
            int monsterAttack = -1;    // Init during battle
            string monsterName = "NOTHING";
            ConsoleColor monsterColour = ConsoleColor.Black; //default
            bool monsterInit = true;  // Sets monster health before battle starts

            string[] monsterNames = { "Joe", "Suq Maddiq", "Sugondese", "Ben Dover" };
            ConsoleColor[] monsterColours = { ConsoleColor.DarkGreen, ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkMagenta };

            string[] graphicGoblin =
            {
                "                        ",
                "       |\\___/|  V       ",
                "     <( Ò   Ó )>|       ",
                "       \\  ^  /  |       ",
                "        V```V           ",
                "                        "
            };
            string[] graphicDemon =
            {
                "   |\\              /|   ",
                "   | \\            / |   ",
                "  /   `~________~'   \\  ",
                " |    {_O_}  {_O_}    |  ",
                "  \\        VV        /  ",
                "   `\\   [######]   /'   ",
                "     `>__________<'      "
            };



            string input;
            input = "";


            Console.Title = "MY FIRST CONSOLE GAME";

            Console.SetWindowSize(screenWidth, screenHeight);
            Console.Clear(); // Clear the screen before changing the buffer size!
            Console.SetBufferSize(screenWidth, screenHeight);


            // ---------- WELCOME SCREEN, DO ONCE -------------

            Console.Clear();
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Cyan;

            int openingScreenX = 0;
            int openingScreenY = 0;
            int openingScreenWidth = 72;
            int openingScreenHeight = 9;

            Console.WriteLine("########################################################################");
            Console.WriteLine("########################################################################");
            Console.WriteLine("###########                                                  ###########");
            Console.WriteLine("###########          WELCOME TO:  'SLAY THE DEMON'!          ###########");
            Console.WriteLine("###########                                                  ###########");
            Console.WriteLine("###########            PRESS ANY KEY TO CONTINUE.            ###########");
            Console.WriteLine("###########                                                  ###########");
            Console.WriteLine("########################################################################");
            Console.WriteLine("########################################################################");

            Console.MoveBufferArea(0, 0, openingScreenWidth, openingScreenHeight, openingScreenX, openingScreenY);

            Console.ReadKey(true);

            // -------------------------------------------------

        
            while(isGameRunning)
            {


            Console.Clear();
            Console.CursorVisible = true;
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);

            // UPDATE THE GAME:
            Console.ForegroundColor = ConsoleColor.Blue;



            // #####################   DRAW GAME STATE   #####################

            // DRAW VISUAL OPPONENT:
            if (playerWins < playerWinsEnd)
            {
                // NORMAL ENEMY:
                if (monsterInit)
                {
                    monsterHealth = 30;
                    monsterAttack = 5;
                    monsterName = monsterNames[randomNum.Next(monsterNames.Length)];
                    monsterColour = monsterColours[randomNum.Next(monsterColours.Length)];
                    monsterInit = false;
                    Console.WriteLine("========= You have encountered Goblin " + monsterName + ". =========");
                }

                // Random colour:
                Console.ForegroundColor = monsterColour;

                // L4 - Show the graphic:

                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(graphicGoblin[i]);
                }

            }
            else
            {
                // BOSS BATTLE:
                if (monsterInit)
                {
                    monsterHealth = 120;
                    monsterAttack = 20;
                    monsterName = "Draconis";
                    monsterInit = false;
                    Console.WriteLine("========= THE DEMON HAS BEEN AWOKEN! =========");
                }

                Console.ForegroundColor = ConsoleColor.Red;

                // L4 - Show the graphic:

                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine(graphicDemon[i]);
                }


                Console.WriteLine(graphicDemon[0]);
                Console.WriteLine(graphicDemon[1]);
                Console.WriteLine(graphicDemon[2]);
                Console.WriteLine(graphicDemon[3]);
                Console.WriteLine(graphicDemon[4]);
                Console.WriteLine(graphicDemon[5]);
                Console.WriteLine(graphicDemon[6]);
            }

            // MOVE 2 BLOCKS BELOW IMAGE:
            Console.CursorTop += 2;

            // SHOW MONSTER HEALTH:
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("ENEMY HEALTH:   " + monsterHealth + "HP");

            // SHOW PLAYER HEALTH:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("PLAYER HEALTH:  " + playerHealth + "HP");

            // SHOW ACTIONS:
            Console.CursorTop += 1;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Type one of the following actions:");
            Console.WriteLine("[" + commandAttack + "]" + "  " + "[" + commandDefend + "]" + "  " + "[" + commandMagic + "]" + "  " + "[" + commandRun + "]");



            // #####################   REQUEST INPUT   #####################
            Console.CursorTop += 2;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            input = "";

            input = Console.ReadLine();



            // #####################   UPDATE GAME   #####################

            message = "";
            if (input == commandAttack || input == commandDefend || input == commandMagic)
            {
                // EVALUATE BATTLE:
                int rand = randomNum.Next(1, 4); // van 1 TOT 4, dus 1 t/m 3
                string monsterCommand;
                if (rand == 1)
                { monsterCommand = commandAttack; }
                else if (rand == 2)
                { monsterCommand = commandDefend; }
                else
                { monsterCommand = commandMagic; }

                if (input == monsterCommand)
                {
                    // DRAW:
                    message = "IT'S A DRAW!";
                }
                else
                {
                    if (
                            (input == commandAttack && monsterCommand == commandMagic) ||
                            (input == commandDefend && monsterCommand == commandAttack) ||
                            (input == commandMagic && monsterCommand == commandDefend)
                        )
                    {
                        // YOU WIN - DEAL DAMAGE:
                        monsterHealth -= playerAttack;
                        message = ("You hit " + monsterName + " ! :D");
                        Console.Beep(1000, 500);
                    }
                    else
                    {
                        // YOU LOSE - RECEIVE DAMAGE:
                        playerHealth -= monsterAttack;
                        message = (monsterName + " hit you! D:");
                        Console.Beep(1100, 500);
                    }

                }

                message += "\n";
                message += "PLAYER:     " + input + "\n";
                message += "ENEMY:      " + monsterCommand;


                if (monsterHealth <= 0)
                {
                    // YOU WON!
                    message += "\n";
                    if (playerWins < playerWinsEnd)
                    {
                        // NORMAL ENEMY:
                        message += "Goblin " + monsterName + " has been defeated!\n";
                        message += ("Your adventure continues... Fights away from demon: " + (playerWinsEnd - (playerWins + 1)));

                        // Heal the player a random amount:
                        int heal = randomNum.Next(healthRestoreMin, healthRestoreMax + 1);
                        playerHealth += heal;
                        if (playerHealth >= playerHealthMax)
                        { playerHealth = playerHealthMax; }

                        message += "\n";
                        message += ("You rested and have gained " + heal + " health. HP TOTAL: " + playerHealth);
                    }
                    else
                    {
                        // END BOSS DEFEATED:
                        message += "THE DEMON HAS BEEN DEFEATED!\n";
                        message += "The people of your city can finally rest.";
                    }
                }
                else if (playerHealth <= 0)
                {
                    // YOU DIED:
                    message += "\n";
                    message += "YOU HAVE DIED IN BATTLE AND FAILED YOUR CONQUEST!\n";
                    message += "The people of your city will face an everlasting reign of terror...";
                }

            }
            else if (input == commandRun)
            {
                // YOU RAN AWAY:
                message += "\n";
                message += "You ran away safely...";

                // Heal the player well:
                playerRunAway = true;
                playerHealth += healthRestoreMax;
                if (playerHealth >= playerHealthMax)
                { playerHealth = playerHealthMax; }

                message += "\n";
                message += ("You were set back " + playerRunSetback + " step(s) in victory.\n");
                message += ("You took a long night rest to recover " + healthRestoreMax + " health. HP TOTAL: " + playerHealth);
            }
            else
            {
                message = "PLEASE GIVE A VALID COMMAND. TRY AGAIN.";
            }



            // SHOW MESSAGE, IF APPLICABLE:
            Console.CursorTop += 1;
            Console.WriteLine(message);

            // L4 - GIVE THE PLAYER TIME TO READ THE MESSAGE:
            Console.ReadKey(true);



            // END GAME:
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Thank you for playing! Press any button to exit.");
            Console.ReadKey(true);


        }
    }
}
}