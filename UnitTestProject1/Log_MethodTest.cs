using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestyJednostkowe;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class Log_MethodTest
    {
        [TestMethod]
        public void LogInvoked()
        {
            //arange
            Mock<ivocabularies> mockObject = new Mock<ivocabularies>();
            //act
            //mockObject.Setup(x => x.Log("tekst"));
            mockObject.Object.Log("tekst");
            //asert
            mockObject.Verify(x => x.Log("tekst"),Times.Exactly(1));
        }
    }
}
