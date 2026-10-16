using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Krylovvs.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool Calculate(string Text)
        {
            //Text.Replace(" ");

            for (int i = 1; i < Text.Length; i++)
            {
                if (Text[i] < Text[i-1])
                {
                    return false;
                } 
            }
            return true;
        }

        public bool CheckWordsAlphabet(string value) {
            for (int i = 1; i < value.Length; i++)
            {
                if (value[i] < value[i-1])
                {
                    return false;
                } 
            }
            return true;
        }
    }
}


namespace tyuiu.cources.programming.interfaces.Sprint1
{
	// Token: 0x02000556 RID: 1366
	//[NullableContext(1)]
	public interface ISprint1Task6V13
	{
		// Token: 0x06000555 RID: 1365
		bool CheckWordsAlphabet(string value);
	}
}
