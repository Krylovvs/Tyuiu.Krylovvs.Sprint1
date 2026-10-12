using Tyuiu.Krylovvs.Sprint1.Task1.V1.Lib;

namespace Tyuiu.Krylovvs.Sprint1.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            double x = 1, y = 1, a = 1;
            double Expected = 1 / 3.0f / 1 + 6.0f * 1;
            DataService Examp = new DataService();
            double Res = Examp.Calculate(a, x, y);
            Assert.AreEqual(Expected, Res);

        }
    }
}
