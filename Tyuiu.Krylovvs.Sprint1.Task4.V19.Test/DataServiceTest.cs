using Tyuiu.Krylovvs.Sprint1.Task4.V19.Lib;

namespace Tyuiu.Krylovvs.Sprint1.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            float Num1 = 1.0f;
            float Num2 = 1.0f;
            float Expected = -2;
            DataService Examp = new DataService();
            double Res = Examp.Calculate(Num1, Num2);
            Assert.AreEqual(Expected, Res);
        }
    }
}
