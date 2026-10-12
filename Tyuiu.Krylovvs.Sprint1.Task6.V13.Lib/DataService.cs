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
    }

    interface ISprint1Task6V13
    {
        public bool Calculate(string Text);
    }
}
