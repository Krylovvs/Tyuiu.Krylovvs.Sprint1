using Tyuiu.Krylovvs.Sprint1.Task0.V5.Lib;

namespace Tyuiu.Krylovvs.Sprint1.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            int Expected = 12;

            int Res = DataService.Calculate();
            Assert.AreEqual(Expected, Res);
        }
    }
}
