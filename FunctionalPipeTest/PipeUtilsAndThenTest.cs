using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionalPipe;

namespace FunctionalPipeTest
{
    [TestClass]
    public class PipeUtilsAndThenTest
    {
        static int[] measurer(String[] words)
        {
            return words.Select(w => w.Length).ToArray();
        }
        static int sum(int[] nrs)
        {
            return nrs.Aggregate((prev, curr) => prev + curr);
        }

        [TestMethod]
        public void TestAndThen()
        {
            Func<String, String[]> splitter = line => line.Split(' ');
            Func<String, int> nrOfChars = splitter.AndThen(measurer).AndThen(sum);
            String src = "Phasellus quam turpis feugiat sit amet ornare in";
            Assert.AreEqual(41, nrOfChars(src));
        }
    }
}
