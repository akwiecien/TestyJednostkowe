using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestyJednostkowe;

namespace UnitTestProject1
{
    [TestClass]
    public class Convert_MethodTest
    {
        [TestMethod]
        public void Should_Return_Upper_Case()
        {
            Mock<ivocabularies> mockObject = new Mock<ivocabularies>();

            mockObject.Setup(x => x.Convert("andrzej")).Returns(() => "ANDRZEJ");

            mockObject.Object.Convert("andrzej");

            mockObject.Verify();
            
        }
    }
}
