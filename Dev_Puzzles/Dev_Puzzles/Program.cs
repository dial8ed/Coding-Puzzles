using Dev_Puzzles.Core.Pyramid;
using Dev_Puzzles.Core.Pyramid.Asterik;
using Dev_Puzzles.UI.OutputAdapters;
using System;
using System.Threading;

namespace Dev_Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new PyramidPrinter(new ConsoleOutputAdapter());

            do
            {
                Intro();                
               
                Console.WriteLine("Running Asterik Pyramid -> C-esque syntax");
                printer.Print<PyramidC>(GetLevel());

                Console.Clear();
                Console.WriteLine("Running Asterik Pyramid -> CLR syntax");
                printer.Print<PyramidCLR>(GetLevel());

                //Console.WriteLine("Running Running Asterik Pyramid -> LINQ syntax");
                //pyramidRunner.Run<PyramidLINQ>(GetLevel());

                Console.WriteLine("Press ENTER to watch again");
                Console.WriteLine("Press ESC to Exit");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);                        
        }

        static void Intro()
        {
            Console.Clear();
            Console.WriteLine("/*******************************************/");
            Console.WriteLine("    Pyramid Coding Puzzle by Justin Dial    ");
            Console.WriteLine("/*******************************************/");
            Thread.Sleep(2000);
            Console.Clear();
        }
        static int GetLevel()
        {            
            Console.WriteLine("Please enter the number of levels (3-15)");

            int level;
            if (!Int32.TryParse(Console.ReadLine(), out level))
                return GetLevel();

            if(level > 2 && level < 16)
                return level;

            return GetLevel();
        }
    }     
}
