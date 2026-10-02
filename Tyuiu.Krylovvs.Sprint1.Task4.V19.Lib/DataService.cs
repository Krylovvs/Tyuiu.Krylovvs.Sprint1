namespace Tyuiu.Krylovvs.Sprint1.Task4.V19.Lib
{
    public class DataService : ISprint1Task4V19
    {
        public double Calculate(float x, float y)
        {
            float Result = (x + y) / Math.Abs(x - 2);

            return Math.Round(Result, 3);
        }
    }

    interface ISprint1Task4V19
    {
        public double Calculate(float x, float y);
    }
}
