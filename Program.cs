using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the numbers of players and press Enter:");
              int m =int.Parse( Console.ReadLine());

            for (int  n = 1; n <= m; n++) {

             
                if(n%3== 0)
                {
                    Console.Write("Fizz,");
                }

                else if (n%5==0)
                {
                    Console.Write("Buzz,");

                }
                else if (n%3 == 0 && n%5==0)
                {

                    Console.Write("FizzBuzz,");
                }
                else 
                {

                    Console.Write($"{n},");
                }

               
            }           
        }
    }
}
