using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionalPipe;

namespace FunctionalPipeTest
{
    [TestClass]
    public class PipeUtilsChainMethodsTest
    {
        [TestMethod]
        public void TestChainMethod()
        {
            double[] a1 = { 16, 25 };
            Func<double[], double[]> f = PipeUtils.ChainMethods<double[]>("ArraysUtils.dll");
            double[] res = f(a1); 

            Assert.AreEqual(64, res[0]);
            Assert.AreEqual(100, res[1]);
        }
    }
}
