using Dev_Puzzles.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev_Puzzles.UnitTests
{
    public class StringBuilderOutputAdapter : IOutputAdapter
    {
        private StringBuilder _builder = new StringBuilder();

        public object Output => _builder.ToString();

        public void Clear() => _builder.Clear();

        public void Write(object output) => _builder.Append(output);
        
        public void WriteLine(object output) => _builder.AppendLine(output.ToString());        

        public void WriteLine() => _builder.AppendLine();
        
    }
}
