using System;

namespace ScriptureMemorizer
{
    class Program
    {
        
        static void Main()
        {
            Scripture scripture = new Scripture("2 Nephi ", 3, 8, "And I will give unto him a commandment that he shall do anone other work, save the work which I shall command him. And I will make him great in mine eyes; for he shall do my work. ");
            //
            Console.Clear();

            scripture.Display(); 

            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWords())
                {
                    Console.WriteLine("\nThanks for remembering my favorite scripture");
                    break;
                }

                Console.Clear();

                scripture.Display();

                Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            }
        }
    }
}