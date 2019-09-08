using System;
using System.Collections.Generic;
using System.Text;

namespace Dev_Puzzles.Core.Pyramid
{
    public interface IPrintPyramid
    {
        void PrintPyramidRot270(int levels);
        void PrintPyramidRot90(int levels);
        void PrintPyramidRot180(int levels);
        void PrintPyramid(int levels);

        IOutputAdapter OutputAdapter { set; }
    }
}
