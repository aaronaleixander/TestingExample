using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingExample;

namespace StringHelperTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        [DataRow("joe.txt")]
        [DataRow("test.TXT")]
        [DataRow("October2019.TXT")]
        [DataRow("   joe.txt")]
        [DataRow("joe.txt   ")]
        [DataRow("   joe.txt   ")]
        [DataRow("null.txt")]
        public void IsTextFile_ValidFileName_ReturnsTrue(string fileName)
        {
            // Act
            bool result = StringHelper.IsTextFile(fileName);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow(".text")]
        [DataRow("hello world")]
        public void IsTextFile_InvalidFileName_ReturnFalse(string fileName)
        {
            // Act
            bool result = StringHelper.IsTextFile(fileName);
            // Assert
            Assert.IsFalse(result);
        }
    }
}
