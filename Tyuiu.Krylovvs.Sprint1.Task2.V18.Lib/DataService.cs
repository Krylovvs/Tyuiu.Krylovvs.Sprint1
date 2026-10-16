using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Krylovvs.Sprint1.Task2.V18.Lib
{
    public class DataService : ISprint1Task2V18
    {
        public int Calculate(int a, int b, int h)
        {
            return 2 * h * (a + b);
        }

        public int CalculateSideSquareParallelepiped(int value, int valueTwo, int valueThree) {
            return 2 * valueThree * (value + valueTwo);
        }
    }
}

namespace tyuiu.cources.programming.interfaces.Sprint1
{
	// Token: 0x02000501 RID: 1281
	public interface ISprint1Task2V18
	{
		// Token: 0x06000500 RID: 1280
		int CalculateSideSquareParallelepiped(int value, int valueTwo, int valueThree);
	}
}
