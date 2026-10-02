using Tyuiu.Krylovvs.Sprint1.Task3.V17.Lib;

namespace Tyuiu.Krylovvs.Sprint1.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            float Num1 = 0.230f;
            bool Expected = true;
            DataService Examp = new DataService();
            bool Res = Examp.Calculate(Num1);
            Assert.AreEqual(Expected, Res);
        }
    }
}
