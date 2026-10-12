namespace Tyuiu.Krylovvs.Sprint1.Task7.V1.Lib
{
    public class DataService : ISprint1Task7V1
    {
        public double Calculate(float a, float b, float c)
        {
            double Result = (b + Math.Sqrt(Math.Pow(b, 2) + 4 * a * c) / 2 * a) -
                Math.Pow(a, 3) * c + Math.Pow(b, -2);

            return Math.Round(Result, 3);
        }
    }

    interface ISprint1Task7V1
    {
        public double Calculate(float a, float b, float c);
    }
}
