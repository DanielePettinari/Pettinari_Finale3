using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemperatureLibrary;

namespace TemperatureLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            int num = 7;
            bool risposta = false;

            bool negativi = Temperature.IsSottoZero(num);
            Assert.AreEqual(risposta, negativi);

        }

        [TestMethod]
        public void TestMethod2()
        { 
            int num = -7;
            bool risposta = true;

            bool negativi = Temperature.IsSottoZero(num);
            Assert.AreEqual(risposta, negativi);

        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] array = new int[] { 6, 5, -12, -33, 77 };
            int numero = 3;

            int neg = Temperature.ContaSottoZero(array);
            Assert.AreEqual(numero, neg);

        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] array = new int[] { 4, -3, -12, -33, -77 };
            int numero = 1;

            int neg = Temperature.ContaSottoZero(array);
            Assert.AreEqual(numero, neg);

        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] array = new int[] { 6, 5, -12, -33, 77 };
            int[] negativo = new int[] { 6, 5, 77 };

            int[] neg = Temperature.Negativi(negativo);
            CollectionAssert.AreEqual(negativo, neg);

        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] array = new int[] { -6, -5, -12, -33, 77 };
            int[] negativo = { 77 };

            int[] neg = Temperature.Negativi(negativo);
            CollectionAssert.AreEqual(negativo, neg);

        }
    }
}