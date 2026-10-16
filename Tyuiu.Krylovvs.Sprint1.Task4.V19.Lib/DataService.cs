using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Krylovvs.Sprint1.Task4.V19.Lib
{
    public class DataService : ISprint1Task4V19
    {
        /*public double Calculate(float x, float y)
        {
            float Result = (x + y) / Math.Abs(x - 2);

            return Math.Round(Result, 3);
        }*/

        public double Calculate(double x, double y) {
            double Result = (x + y) / Math.Abs(x - 2);

            return Math.Round(Result, 3);
        }

    }

    
}
namespace tyuiu.cources.programming.interfaces.Sprint1
{
	// Token: 0x02000535 RID: 1333
	public interface ISprint1Task4V19
	{
		// Token: 0x06000534 RID: 1332
		double Calculate(double x, double y);
	}
}