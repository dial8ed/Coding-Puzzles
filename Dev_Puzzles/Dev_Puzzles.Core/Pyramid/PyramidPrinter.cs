using System;
using System.Threading;

namespace Dev_Puzzles.Core.Pyramid
{
   public class PyramidPrinter
    {
        private IOutputAdapter _outputAdapter;
        private int _sleepTime = 2000;

        public PyramidPrinter(IOutputAdapter outputAdapter)
        {
            _outputAdapter = outputAdapter;
        }

        public void Print<T>(int levels) where T: IPrintPyramid
        {
            var printer = CreatePrinter<T>();
            
            _outputAdapter.Clear();
            _outputAdapter.WriteLine($"Normal Orientation - {levels} levels.");
            printer.PrintPyramid(levels);
            Thread.Sleep(_sleepTime);

            _outputAdapter.Clear();
            _outputAdapter.WriteLine($"Rotated 90 Degrees - {levels} levels.");
            printer.PrintPyramidRot90(levels);
            Thread.Sleep(_sleepTime);

            _outputAdapter.Clear();
            _outputAdapter.WriteLine($"Rotated 180 Degrees - {levels} levels.");
            printer.PrintPyramidRot180(levels);
            Thread.Sleep(_sleepTime);

            _outputAdapter.Clear();
            _outputAdapter.WriteLine($"Rotated 270 Degrees - {levels} levels.");
            printer.PrintPyramidRot270(levels);
            Thread.Sleep(_sleepTime);

        }

        private IPrintPyramid CreatePrinter<T>() where T : IPrintPyramid
        {
            IPrintPyramid instance = Activator.CreateInstance<T>() as IPrintPyramid;

            if (instance is OutputObject)
            {
                ((OutputObject)instance).OutputAdapter = _outputAdapter;
            }

            return instance;
        }
    }
}
