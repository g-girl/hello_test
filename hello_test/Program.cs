using System;

namespace hello_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 10);
            int userNumber;
            Console.WriteLine("Input your chosen number");
            var userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            while (true) {
                
                
                if (random == userNumber) {
                    Console.WriteLine("Goodjob!");
                    Console.ReadLine();
                    break;

                }
                if (random < userNumber) {
                    Console.WriteLine("Try a lower number!");
                    Console.ReadLine();

                }

                if (random > userNumber) {
                    Console.WriteLine("Try a higher number!");
                    Console.ReadLine();

                }


                Console.ReadLine();
            }
            





        }
    }
}
