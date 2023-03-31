using AsyncProg;

namespace OverTImeWageTest
 
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] arr = { 9, 18, 30, 1.8 };
            Assert.AreEqual(294, OverTimeWage.OverTime(arr));
        }
        [TestMethod]
        public void TestMethod2()
        {
            double[] arr = { 9, 10, 30, 1.8 };
            Assert.AreEqual(89.54, OverTimeWage.OverTime(arr));
        }
        [TestMethod]
        public void TestMethod3()
        {
            double[] arr = { 9,20 , 30, 1.8 };
            Assert.AreEqual(402.00, OverTimeWage.OverTime(arr));
        }
    }
}
