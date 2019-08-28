using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestContextDemo
{
    [TestClass]
    public class UnitTest1
    {
        // TestContext : to get test info name , state etc  : to get webservices url info etc
        // Asp.net form testing : to access Page object

        //Data-drive uni test: the TextContext class is required because it provides access to the data row.
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInıt()
        {
            TestContext.WriteLine("---TestInitialize---\n");
            TestContext.WriteLine("---Test Name {0}",TestContext.TestName);
         
            TestContext.WriteLine("---Test Status {0}",TestContext.CurrentTestOutcome);

            TestContext.Properties["info"] = "extra info";


        }
        [TestCleanup]
        public void TestCleanup()
        {
            TestContext.WriteLine("---TestCleanup---\n");
            TestContext.WriteLine("---Test Name {0}", TestContext.TestName);
           // we can log the test results
            TestContext.WriteLine("---Test Status {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("---Test extra info {0}", TestContext.Properties["info"]);

        }
        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine("---TestMethod1---\n");
            TestContext.WriteLine("---Test Name {0}", TestContext.TestName);
            TestContext.WriteLine("---Test Status {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("---Test Class {0}", TestContext.FullyQualifiedTestClassName);

            TestContext.WriteLine("---Test extra info {0}", TestContext.Properties["info"]);

            Assert.AreEqual(1, 1);
        }

        

    }
}
