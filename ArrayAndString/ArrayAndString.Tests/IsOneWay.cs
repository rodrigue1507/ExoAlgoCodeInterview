using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Cryptography;

namespace ArrayAndString.Tests
{
    [TestClass]
    public class IsOneWay
    {
        private readonly ArrayAndStringExercises _arrayAndString;
        public IsOneWay()
        {
            _arrayAndString = new ArrayAndStringExercises();
        }
        [TestMethod]
        [DataRow("pale","ple")]
        [DataRow("pales","pale")]
        [DataRow("pale","bale")]
        public void IsOneWay_ReturnTrue(string s1,string s2)
        {
            var result = _arrayAndString.OneWay(s1, s2);
            Assert.IsTrue(result,$"{s1} and {s2} should be One Way");
        }

        [TestMethod]
        [DataRow("pale","bake")]
        public void IsOneWay_ReturnFalse(string s1, string s2)
        {
            var result = _arrayAndString.OneWay(s1, s2);
            Assert.IsFalse(result,$"{s1} and {s2} should not be One Way");
        }
    }
}
