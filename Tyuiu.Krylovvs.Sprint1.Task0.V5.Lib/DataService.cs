using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Krylovvs.Sprint1.Task0.V5.Lib
{
    public class DataService : ISprint1Task0V8
    {
        public double Calculate()
        {
            // 8 15/2/4
            //return (1.0d + 2.0d) * (1.0d + 9.0d / 3.0d);

            return 15.0f / 2.0f / 4.0f;
        }
    }

}

namespace tyuiu.cources.programming.interfaces.Sprint1
{
    public interface ISprint1Task0V8
    {
        double Calculate();
    }
}