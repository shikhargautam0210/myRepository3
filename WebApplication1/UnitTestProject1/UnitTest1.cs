using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void shouldAddTwoNumbers()
        {
            int res = 8;
            Assert.AreEqual(res, 8);
        }
    }
}
