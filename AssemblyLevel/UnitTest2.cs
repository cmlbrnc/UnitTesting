using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssemblyLevel
{
    [TestClass]
   public class UnitTest2
    {
        
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

        private List<string> _userList;
        [TestInitialize]
        public void TestInitialize()
        {
            _userList = new List<string>();

            _userList.Add("Cemil");

            _userList.Add("Taner");

            _userList.Add("Ahmet");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Debug.WriteLine("Running TestInitialize");
        }

        [TestMethod]
        public void same_element_same_order()
        {
            List<string> _newUsersList = new List<string>();

            _newUsersList.Add("Cemil");

            _newUsersList.Add("Taner");

            _newUsersList.Add("Ahmet");

            CollectionAssert.AreEqual(_userList, _newUsersList);
            //CollectionAssert.AreNotEqual(_userList, _newUsersList);
        }

        [TestMethod]
        public void same_element_different_order()
        {
            List<string> _newUsersList = new List<string>();

            _newUsersList.Add("Taner");
            _newUsersList.Add("Cemil");

            _newUsersList.Add("Ahmet");

            CollectionAssert.AreEquivalent(_userList, _newUsersList);
          //  CollectionAssert.AreNotEquivalent(_userList, _newUsersList);
        }

        [TestMethod]
        public void not_null()
        {
           

         

            CollectionAssert.AllItemsAreNotNull(_userList);
       
        }

        [TestMethod]
        public void isSubsetOf_test()
        {
            List<string> _newUsersList = new List<string>{"Cemil","Taner","Talip"};

            List<string> _formerUsersList = new List<string> { "Cemil", "Talip" };






            CollectionAssert.IsSubsetOf(_newUsersList,_userList,"IsSubsetOf Failed");

            CollectionAssert.IsNotSubsetOf(_formerUsersList, _userList);

        }

        [TestMethod]
        public void all_items_are_unique()
        {
          



            CollectionAssert.AllItemsAreUnique(_userList);

        }

        [TestMethod]
        public void Contains_DoesNotCon()
        {




            CollectionAssert.Contains(_userList,"Cemil");
            CollectionAssert.DoesNotContain(_userList, "sfe");

        }

        [TestMethod]
        public void all_items_same_type()
        {




            CollectionAssert.AllItemsAreInstancesOfType(_userList,typeof(string));

        }

        [TestMethod]
        public void TestMethod4()
        {
            double expected = 3.1622;
            //Formula : expected-actual =delta
            double delta = 0.0001;

            double actual = Math.Sqrt(10);

            Assert.AreEqual(expected,actual,delta);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string expected = "hello";
            //Formula : expected-actual =delta
           

            string actual = "HELLO";

            Assert.AreEqual(expected, actual, true);
        }

        [TestMethod]
        public void TestMethod6()
        {
            const double expected = 0;
            //Formula : expected-actual =delta
            

            var actual = Math.Pow(5,1); 

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod7()
        {
            int a = 10;
            int b = a;

          //  Assert.AreEqual(a,b,"areequal failed");
           Assert.AreSame(a, b, "areSame failed"); // checking its References
        }

        [TestMethod]
        public void TestMethod8()
        {
            int a = 10;
            int b = a;

           
            Assert.AreEqual(1,1);
            Assert.Inconclusive("test is okay. test is not sufficent"); 
        }

        [TestMethod]
        public void TestMethod9()
        {

            var number = 5m;

         
            Assert.IsInstanceOfType(number, typeof(decimal));
            Assert.IsNotInstanceOfType(number, typeof(int));

        }

        [TestMethod]
        public void TestMethod10()
        {

            var number = 5m;


            Assert.IsTrue(10%2==0);
            Assert.IsFalse(10%2==1);

        }

        [TestMethod]
        public void TestMethod11()
        {
            List<string> names=new List<string>{"Cemil","Taner","Hasan"};

            var startWithE = names.FirstOrDefault(t => t.StartsWith("E"));

            var startWithT = names.FirstOrDefault(t => t.StartsWith("T"));

            Assert.IsNull(startWithE,"IsNull failed");

            Assert.IsNotNull(startWithT, "IsNotNull  failed");

        }

        [TestMethod]
        public void TestMethod12()
        {
            //Asert.Fail provide failing the test
            try
            {
                var number = 5;
                int result = number/ 0;
            }
            catch (DivideByZeroException e)
            {

                Assert.Fail("Test Failed");
            }


        }


        [TestMethod]
        public void StringContainsTest()
        {
           
            StringAssert.Contains("Test World", "Test");
        }


        [TestMethod]
        public void StringMatchesTest()
        {

            StringAssert.Matches("amazon fires", new Regex(@"[a-zA-z]"));

            StringAssert.DoesNotMatch("amazon fires", new Regex(@"[0-9]"));
        }

        [TestMethod]
        public void StartWithTest()
        {  
            StringAssert.StartsWith("amazon fires", "amazon");
        }
        [TestMethod]
        public void EndWithTest()
        {
            StringAssert.EndsWith("amazon fires", "fires");
        }

    }
}
