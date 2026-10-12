using Tyuiu.Krylovvs.Sprint1.Task5.V6.Lib;

namespace Tyuiu.Krylovvs.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            int Num1 = 1;
            int Res = 0;
            int Expected = 1;
            DataService Examp = new DataService();
            Examp.Calculate(Num1, ref Res);
            Assert.AreEqual(Expected, Res);
        }
    }
}
