using System;
using System.Collections.Generic;
using System.Text;

namespace Dev_Puzzles.Core.Pyramid
{
    public interface IPrintPyramid
    {
        void PrintPyramidRot270(int levels);
        void PrintPyramidRot90(int levels);
        void PrintPyramid1_180(int levels);
        void PrintPyramid1(int levels);

        IOutputAdapter OutputAdapter { set; }
    }
}
