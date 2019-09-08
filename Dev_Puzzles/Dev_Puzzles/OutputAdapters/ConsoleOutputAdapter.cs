using Dev_Puzzles.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev_Puzzles.UI.OutputAdapters
{
    public class ConsoleOutputAdapter : IOutputAdapter
    {
        public object Output => Console.Out;

        public void Clear() => Console.Clear();        

        public void Write(object output) => Console.Write(output);
        
        public void WriteLine(object output) => Console.WriteLine(output);

        public void WriteLine() => Console.WriteLine();

    }
}
