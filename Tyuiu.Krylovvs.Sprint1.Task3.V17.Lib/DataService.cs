namespace Tyuiu.Krylovvs.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool Calculate(float Input)
        {
            int Flex = (int)(Math.Abs(Input) * 1000) % 1000;

            return Flex % 10 == 0 ||
                   Flex / 10 % 10 == 0 ||
                   Flex / 100 == 0;
        }
    }

    interface ISprint1Task3V17
    {
        public bool Calculate(float Input);
    }
}
