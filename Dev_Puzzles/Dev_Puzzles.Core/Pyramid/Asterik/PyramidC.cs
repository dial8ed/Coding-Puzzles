using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Dev_Puzzles.Core.Pyramid.Asterik
{
    public class PyramidC : OutputObject, IPrintPyramid
    {
        public void PrintPyramid1(int levels)
        {            
            // Top to Bottom
            for (int i = 0; i <= levels; i++)
            {
                //spaces
                for (int k = 0; k < (levels - i) + 1; k++)
                    OutputAdapter.Write(" ");

                // asterik
                for (int j = 0; j < (i * 2) -1; j++)
                    OutputAdapter.Write("*");

                OutputAdapter.WriteLine();
            }
        }

        public void PrintPyramid1_180(int levels)
        {
            // Bottom to Top
            for (int i = levels; i > 0; i--)
            {
                // Spaces
                for (int k = 0; k < (levels - i) + 1; k++)
                    OutputAdapter.Write(" ");

                // Asteriks
                for (int j = 0; j < (i * 2) - 1; j++)
                    OutputAdapter.Write("*");

                OutputAdapter.WriteLine();
            }
        }

        public void PrintPyramidRot90(int levels)
        {            
            // Left to Right
            for (var j = 0; j <= (levels * 2) - 1; j++)
            {       
                // Expand Out                
                if(j <= levels)
                    for (int k = 0; k < j; k++)
                        OutputAdapter.Write("*");
                // Contract In
                else
                    for(int l=(levels * 2)-j; l > 0; l--)
                        OutputAdapter.Write("*");

                OutputAdapter.WriteLine("");
            }                       
        }

        public void PrintPyramidRot270(int levels)
        {
            // Right to Left
            for (var j = 0; j <= (levels * 2) - 1; j++)
            {
                // Expand Out
                if (j <= levels)
                {
                    // Spaces
                    for (int kk = 0; kk < (levels - j); kk++)
                    {
                        OutputAdapter.Write(" ");
                    }
                    // Asteriks
                    for (int k = 0; k < j; k++)
                    {
                        OutputAdapter.Write("*");
                    }
                }
                // Retract In
                else 
                {
                    // Spaces
                    for (int ll = 0; ll < j - levels; ll++)
                    {
                        OutputAdapter.Write(" ");
                    }
                    // Asteriks
                    for (int l = (levels * 2) - j; l > 0; l--)
                    {
                        OutputAdapter.Write("*");
                    }                        
                }

                OutputAdapter.WriteLine();
            }
        }
    }
}