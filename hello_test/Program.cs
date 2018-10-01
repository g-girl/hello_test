using System;
using System.Linq;

namespace hello_test
{
    class Program
    {
        private static void Main() {
            Random random = new Random();
            int computerNumber = random.Next(1, 10);

            Console.WriteLine("Input a number: ");
            
            int count = 0;

            bool playing = true;
            while (playing) {
                string userInput = Console.ReadLine();
                count++;

                int.TryParse(userInput, out int userNumber);

                if (computerNumber == userNumber) {
                    Console.WriteLine("You win! You are awesome, stay classy and in school");
                    var tryPlurality = count == 1 ? "try" : "tries";
                 
                    Console.WriteLine($"It took you {count} {tryPlurality}!");
                    Console.ReadLine();
                    break;
                }
                else if (computerNumber > userNumber) {
                    Console.WriteLine("Higher");
                 
                }
                else {
                    Console.WriteLine("Lower");
                    
                }

            }

        }
        




        
    }
}
