namespace Tyuiu.Krylovvs.Sprint1.Task1.V1.Lib
{
    public class DataService : ISprint1Task1V1
    {
        public float Calculate(float x, float y, float a)
        {
            return x / 3.0f / y + 6.0f * a;
        }
    }

    interface ISprint1Task1V1
    {
        public float Calculate(float x, float y, float a);
    }
}
