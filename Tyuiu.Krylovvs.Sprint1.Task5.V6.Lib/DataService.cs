using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Krylovvs.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public void Calculate(int k, ref int n)
        {
            n = ((k - 1) % 7) + 1;
        }
        
        public int Calculate(int k) {
            return ((k - 1) % 7) + 1;
        }
    }
}
namespace tyuiu.cources.programming.interfaces.Sprint1
{
	// Token: 0x02000547 RID: 1351
	public interface ISprint1Task5V6
	{
		// Token: 0x06000546 RID: 1350
		int Calculate(int k);
	}
}