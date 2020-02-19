using System;

namespace Urval_Patel_Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value between 2 and 10:");
            
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int j;

            if (i%2==0)
            {
                i++;
                for (j = 0; j < i; j++)
                {
                    
                    Console.WriteLine(j + 1 + ". You entered an even number") ;
                }
            }


            else
            {
                i--;
                for (j = 0; j < i; j++)

                {
                    Console.WriteLine(j + 1 + ". You entered an odd number");
                }
                
            }           
        }
    }
}
