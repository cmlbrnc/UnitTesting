using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Helpers.Test
{
    [TestClass]
    public class StringHelperTest
    {
        [TestMethod]
        public void Trim_whitespace_at_eft_and_right_of_the_input()
        {
            //Arrange
            var input = "   Cemil Birinci  ";
            var expectedResult = "Cemil Birinci";

            var actualResult=StringHelper.RemoveWhiteSpace(input);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void Trim_whitespace_inside_input()
        {
            //Arrange
            var input = "    Cemil Birinci     Salih    demirog     Ahmet   Sait  Durann ";
            var expectedResult = "Cemil Birinci Salih demirog Ahmet Sait Durann";

            var actualResult = StringHelper.RemoveWhiteSpace(input);

            Assert.AreEqual(expectedResult, actualResult);

        }
    }

}
