namespace Tyuiu.Krylovvs.Sprint1.Task2.V18.Lib
{
    public class DataService : ISprint1Task2V18
    {
        public int Calculate(int a, int b, int h)
        {
            return 2 * h * (a + b);
        }
    }

    interface ISprint1Task2V18
    {
        public int Calculate(int a, int b, int h);
    }
}
