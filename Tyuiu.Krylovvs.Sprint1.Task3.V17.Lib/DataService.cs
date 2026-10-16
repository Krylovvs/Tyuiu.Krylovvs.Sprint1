using tyuiu.cources.programming.interfaces.Sprint1;

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

        public bool ZeroCheck(double number) {
            int Flex = (int)(Math.Abs(number) * 1000) % 1000;

            return Flex % 10 == 0 ||
                   Flex / 10 % 10 == 0 ||
                   Flex / 100 == 0;
        }
    }
}

namespace tyuiu.cources.programming.interfaces.Sprint1
{
	// Token: 0x0200051F RID: 1311
	public interface ISprint1Task3V17
	{
		// Token: 0x0600051E RID: 1310
		bool ZeroCheck(double number);
	}
}
