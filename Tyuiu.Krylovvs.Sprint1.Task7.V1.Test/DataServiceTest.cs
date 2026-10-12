using Tyuiu.Krylovvs.Sprint1.Task7.V1.Lib;

namespace Tyuiu.Krylovvs.Sprint1.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            float Num1 = 1.0f;
            float Num2 = 1.0f;
            float Num3 = 1.0f;
            double Expected = Math.Round(2.118f, 3);
            DataService Examp = new DataService();
            double Res = Examp.Calculate(Num1, Num2, Num3);
            Assert.AreEqual(Expected, Math.Round(Res, 3));
        }
    }
}
