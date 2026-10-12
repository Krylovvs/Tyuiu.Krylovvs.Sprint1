using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Krylovvs.Sprint1.Task0.V5.Lib
{
    public class DataService : ISprint1Task0V5
    {
        public double Calculate()
        {
            Console.WriteLine((1 + 2) * (1 + 9 / 3));
            return (1 + 2) * (1 + 9 / 3);
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