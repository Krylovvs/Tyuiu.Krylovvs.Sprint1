namespace Tyuiu.Krylovvs.Sprint1.Task0.V5.Lib
{
    public class DataService : ISprint1Task0V5
    {
        public int Calculate()
        {
            return (1 + 2) * (1 + 9 / 3);
        }
    }

    interface ISprint1Task0V5
    {
        public int Calculate();
    }
}
