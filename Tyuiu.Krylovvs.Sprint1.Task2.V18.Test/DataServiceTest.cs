using Tyuiu.Krylovvs.Sprint1.Task2.V18.Lib;

namespace Tyuiu.Krylovvs.Sprint1.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            int x = 1, y = 1, a = 1;
            float Expected = 4;
            DataService Examp = new DataService();
            float Res = Examp.Calculate(x, y, a);
            Assert.AreEqual(Expected, Res);

        }
    }
}
