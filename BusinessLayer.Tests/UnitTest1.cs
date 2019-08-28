using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLayer.Tests
{
    //data driven test: we use it when we want to import data to db. 
    //example :excel to db , validation data for db.
    //// to test same unit test with different values dynamically***
    /// 
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Users.xml",
            "User",DataAccessMethod.Sequential)]
        [TestMethod]
        public void DataTest()
        {
            var manager =new UserManager();
            var name = TestContext.DataRow["name"].ToString();
            var tel = TestContext.DataRow["tel"].ToString();
            var email = TestContext.DataRow["email"].ToString();
            var result = manager.AddUser(name, tel, email);

            Assert.IsTrue(result);
        }
        /// [DataSource("MyDataSource"),TestMethod]
        /// Proble connection with the App.Config
       
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.SQL",
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;",
            "Numbers", DataAccessMethod.Sequential)]

        // connection problem with the database 


        [TestMethod]
        public void DataTest2()
        {
            var manager = new OperationManager();
            int x = Convert.ToInt32(TestContext.DataRow["x"]);
            int y = Convert.ToInt32(TestContext.DataRow["y"]);

            int expected = Convert.ToInt32(TestContext.DataRow["expected"]);

            int actualResult = manager.Sum(x, y);

            Assert.AreEqual(expected,actualResult);
        }
    }
}
