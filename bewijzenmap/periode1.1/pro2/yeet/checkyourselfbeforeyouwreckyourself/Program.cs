using System;

namespace canyoudrive
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getal A //

            int a= 0;
            a++;
            a += 1;
            a= a + 1;

            // Getal B //

            int b= 0;
            b--;
            b -= 1;
            b= b - 1;
     
            // Als het helemaal goed is //

            if (a == 3 && b == -3)
            {
                Console.Clear();
                Console.WriteLine("-----------------");
                Console.WriteLine("Getal a is {0}", a); 
                Console.WriteLine("-----------------");
                Console.WriteLine("Getal b is {0}", b);  
                Console.WriteLine("-----------------");  
                Console.WriteLine("You Did It!!!");
                Console.WriteLine("-----------------");
            }

            // Als het bijna goed is. //

            else if (a == 3 || b == -3 )
            {
                Console.Clear();
                Console.WriteLine("----------------------");
                Console.WriteLine("Getal a is {0}", a); 
                Console.WriteLine("----------------------");
                Console.WriteLine("Getal b is {0}", b);  
                Console.WriteLine("----------------------");  
                Console.WriteLine("You're Almost There!!!");
                Console.WriteLine("----------------------");
            }

            //Als het helemaal fout is //

            else
            {
                Console.Clear();
                Console.WriteLine("-----------------");
                Console.WriteLine("Getal a is {0}", a); 
                Console.WriteLine("-----------------");
                Console.WriteLine("Getal b is {0}", b);  
                Console.WriteLine("-----------------");  
                Console.WriteLine("Try Again");
                Console.WriteLine("-----------------");
            }
        }
    }
}