using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Krylovvs.Sprint1.Task1.V1.Lib
{
    public class DataService : ISprint1Task1V1
    {
        public double Calculate(double a, double x, double y)
        {
            return x / 3.0f / y + 6.0f * a;
        }
    }
}

namespace tyuiu.cources.programming.interfaces.Sprint1
{
    // Token: 0x020004D1 RID: 1233
    public interface ISprint1Task1V1
    {
        // Token: 0x060004D0 RID: 1232
        double Calculate(double a, double x, double y);
    }
}
