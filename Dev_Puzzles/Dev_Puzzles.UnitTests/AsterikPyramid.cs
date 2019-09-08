using Dev_Puzzles.Core;
using Dev_Puzzles.Core.Pyramid.Asterik;
using Dev_Puzzles.UnitTests;
using NUnit.Framework;
using System.Text;

namespace Tests
{
    public class Tests
    {
        IOutputAdapter _outputAdapter;

        [SetUp]
        public void Setup()
        {
            _outputAdapter = new StringBuilderOutputAdapter();
        }

        [Test]
        public void PrintedNormalOrientationIsCorrect()
        {
            var pC = new PyramidC() { OutputAdapter = _outputAdapter };

            var sb = new StringBuilder();
            sb.AppendLine("   *");
            sb.AppendLine("  ***");
            sb.AppendLine(" *****");

            pC.PrintPyramid(3);

            Assert.IsTrue(sb.ToString() == pC.OutputAdapter.Output.ToString());
            
        }
    }
}