using System;
using System.Collections.Generic;
using System.Text;

namespace Dev_Puzzles.Core
{
    public interface IOutputAdapter
    {
        void Clear();
        void Write(object output);
        void WriteLine(object output);
        void WriteLine();
        object Output { get; }
    }
}
