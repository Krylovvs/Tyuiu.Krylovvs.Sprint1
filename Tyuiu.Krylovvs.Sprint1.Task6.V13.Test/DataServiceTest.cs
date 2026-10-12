using Tyuiu.Krylovvs.Sprint1.Task6.V13.Lib;

namespace Tyuiu.Krylovvs.Sprint1.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            string Text1 = "abcd";
            bool Expected = true;
            DataService Examp = new DataService();
            bool Res = Examp.Calculate(Text1);
            Assert.AreEqual(Expected, Res);
        }
    }
}
