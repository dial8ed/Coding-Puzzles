using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dev_Puzzles.Core.Pyramid.Asterik
{
    public class PyramidCLR : OutputObject, IPrintPyramid
    {
        public void PrintPyramid1(int levels)
        {
            var j = 0;
            while (j < levels)
            {
                j += 1;
                var spaces = String.Join(" ", Enumerable.Repeat("", (levels - j) + 2));
                var asteriks = String.Join("", Enumerable.Repeat("*", (j * 2) - 1));
                OutputAdapter.WriteLine(spaces + asteriks);
            }
        }

        public void PrintPyramid1_180(int levels)
        {
            var j = levels;

            while (j > 0)
            {
                var spaces = String.Join(" ", Enumerable.Repeat("", (levels - j) + 2));
                var asteriks = String.Join("", Enumerable.Repeat("*", (j * 2) - 1));
                OutputAdapter.WriteLine(spaces + asteriks);
                j--;
            }
        }

        public void PrintPyramidRot270(int levels)
        {
            OutputAdapter.WriteLine("COMINGSOON");
            //throw new NotImplementedException();
        }

        public void PrintPyramidRot90(int levels)
        {
            OutputAdapter.WriteLine("COMINGSOON");
            //throw new NotImplementedException();
        }
    }
}
