using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Dev_Puzzles
{
    public static class Pyramid
    {
        public static void Run(int levels)
        {
            
            Console.Clear();
            Console.WriteLine($"Normal Orientation - {levels} levels.");
            PrintPyramid1(levels);
            Thread.Sleep(5000);

            Console.Clear();
            Console.WriteLine($"Rotated 90 Degrees - {levels} levels.");
            PrintPyramidRot90(levels);
            Thread.Sleep(5000);

            Console.Clear();
            Console.WriteLine($"Rotated 180 Degrees - {levels} levels.");
            PrintPyramid1_180(levels);
            Thread.Sleep(5000);

            Console.Clear();
            Console.WriteLine($"Rotated 270 Degrees - {levels} levels.");
            PrintPyramidRot270(levels);
            Thread.Sleep(5000);

        }

        static void PrintPyramid1(int levels)
        {
            
            // rows
            for (int i = 0; i <= levels; i++)
            {
                //spaces
                for (int k = 0; k < (levels - i) + 1; k++)
                    Console.Write(" ");

                // asterik
                for (int j = 0; j < (i * 2) -1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        //static void PrintPyramid2(int levels)
        //{
        //    var j = 0;
        //    while (j < levels)
        //    {
        //        j += 1;
        //        var spaces = String.Join(" ", Enumerable.Repeat("", (levels - j) + 2));
        //        var asteriks = String.Join("", Enumerable.Repeat("*", (j * 2) - 1));
        //        Console.WriteLine(spaces + asteriks);
        //    }
        //}

        //static void PrintPyramid2_180(int levels)
        //{
        //    var j = levels;

        //    while (j > 0)
        //    {
        //        var spaces = String.Join(" ", Enumerable.Repeat("", (levels - j) + 2));
        //        var asteriks = String.Join("", Enumerable.Repeat("*", (j * 2) - 1));
        //        Console.WriteLine(spaces + asteriks);
        //        j--;
        //    }
        //}

        static void PrintPyramid1_180(int levels)
        {
            // rows
            for (int i = levels; i > 0; i--)
            {
                //spaces
                for (int k = 0; k < (levels - i) + 1; k++)
                    Console.Write(" ");

                // asterik
                for (int j = 0; j < (i * 2) - 1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        static void PrintPyramidRot90(int levels)
        {
            for(var j = 0; j <= (levels * 2) - 1; j++)
            {                
                if(j <= levels)
                    for (int k = 0; k < j; k++)
                        Console.Write("*");
                else
                    for(int l=(levels *2)-j; l > 0; l--)                    
                        Console.Write("*");
                
                Console.WriteLine();
            }                       
        }

        static void PrintPyramidRot270(int levels)
        {
            for (var j = 0; j <= (levels * 2) - 1; j++)
            {
                if (j <= levels)
                {
                    for (int kk = 0; kk < (levels - j); kk++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < j; k++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int ll = 0; ll < j - levels; ll++)
                    {
                        Console.Write(" ");
                    }
                    for (int l = (levels * 2) - j; l > 0; l--)
                    {
                        Console.Write("*");
                    }                        
                }
                    
                Console.WriteLine();
            }
        }
    }
}