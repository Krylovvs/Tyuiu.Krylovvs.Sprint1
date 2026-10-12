namespace Tyuiu.Krylovvs.Sprint1.Task5.V6.Lib
{
    public class DataService
    {
        public void Calculate(int k, ref int n)
        {
            n = ((k - 1) % 7) + 1;
        }
    }

    interface ISprint1Task5V6
    {
        public void Calculate(int k, ref int n) { }
    }
}
