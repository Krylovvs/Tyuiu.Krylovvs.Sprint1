using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Krylovvs.Sprint1.Task0.V5.Lib
{
    public class DataService : ISprint1Task0V5
    {
        public double Calculate()
        {
            // 8 15/2/4
            int Res = (1 + 2) * (1 + 9 / 3);
            return Res;
        }
    }

}

namespace tyuiu.cources.programming.interfaces.Sprint1
{
    public interface ISprint1Task0V5
    {
        double Calculate();
    }
}