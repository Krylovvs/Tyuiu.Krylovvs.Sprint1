using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Krylovvs.Sprint1.Task7.V1.Lib
{
    public class DataService : ISprint1Task7V1
    {
        public double OldCalculate(float a, float b, float c)
        {
            double Result = (b + Math.Sqrt(Math.Pow(b, 2) + 4 * a * c) / 2 * a) -
                Math.Pow(a, 3) * c + Math.Pow(b, -2);

            return Math.Round(Result, 3);
        }

        public double Calculate(double a, double b, double c)
        {
            double Result = (b + Math.Sqrt(Math.Pow(b, 2) + 4 * a * c) / 2 * a) -
            Math.Pow(a, 3) * c + Math.Pow(b, -2);

            return Math.Round(Result, 3);
        }
    }
}

namespace tyuiu.cources.programming.interfaces.Sprint1
{
	// Token: 0x0200055D RID: 1373
	public interface ISprint1Task7V1
	{
		// Token: 0x0600055C RID: 1372
		double Calculate(double a, double b, double c);
	}
}

