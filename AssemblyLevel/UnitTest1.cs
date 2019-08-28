using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssemblyLevel
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            Debug.WriteLine("Running AssemblyInıtialize");
        }

      


        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Debug.WriteLine("Running AssemblyCleanUp");
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Debug.WriteLine("Running ClassInitialize");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Debug.WriteLine("Running ClassCleanup");
        }
        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("Running TestInitialize");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Debug.WriteLine("Running TestInitialize");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Debug.WriteLine("Running TestMethod1");
        }

        [TestMethod,Description("this is test method which is ....")]
        [Timeout(100)]
        public void TestMethod2()
        {
            Thread.Sleep(1500);
            Debug.WriteLine("Running TestMethod2");
        }

        [TestMethod, Timeout(100)]
        
        [Owner("Cemil")]
        [TestCategory("Tester")]
        [Priority(1)]
        [TestProperty("Update by","taner")]
        [TestProperty("Update2 by", "jack")]
        
        public void Attribute()
        {
            Thread.Sleep(1500);
            Debug.WriteLine("Running Att");
        }

        [TestMethod,Timeout(TestTimeout.Infinite)]
        [Priority(2)]
        [ExpectedException(typeof(Exception),AllowDerivedTypes = true)]
        [Ignore]
        public void TestMethod3()
        {
            Debug.WriteLine("Running TestMethod2");
        }

     
    }
}
