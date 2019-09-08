using System;
using System.Linq;

namespace Dev_Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {                                               
            do
            {
                Intro();
                Pyramid.Run(GetLevel());
                
                Console.WriteLine("Press ENTER to watch again");
                Console.WriteLine("Press ESC to Exit");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);                        
        }

        static void Intro()
        {
            Console.Clear();
            Console.WriteLine("Pyramid Coding Puzzle by Justin Dial");
        }
        static int GetLevel()
        {            
            Console.WriteLine("Please enter the number of levels (3-20)");

            int level;
            if (!Int32.TryParse(Console.ReadLine(), out level))
                return GetLevel();

            if(level > 2 && level < 21)
                return level;

            return GetLevel();
        }
    }     
}
