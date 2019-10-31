using System;

namespace wirwar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------"); 
            Console.WriteLine("");
            Console.WriteLine("Wie ben jij eigenlijk?");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------"); 

            Console.WriteLine("");
            String name = Console.ReadLine();
           
            Console.Clear();


            if(name == "Erwin"|| name=="erwin"){    
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine(" Goedemorgen Erwin!");
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------");
            }
            else if(name == "Erik"||name=="erik"){
                Console.WriteLine("--------------------------------");
                Console.WriteLine("");
                Console.WriteLine(" Goedemorgen Erik! ");
                Console.WriteLine("");
                Console.WriteLine("--------------------------------");
            }
            else if(name=="Alex" || name=="alex"){
                Console.WriteLine("-----------------------------");
                Console.WriteLine("");
                Console.WriteLine(" Goedemorgen Alex! ");
                Console.WriteLine("");
                Console.WriteLine("-----------------------------");
            }
            
            else
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("");
                Console.WriteLine(" Exqueeze me who are you? ");
                Console.WriteLine("");
                Console.WriteLine("-----------------------");
            } 
        }
    }
}

