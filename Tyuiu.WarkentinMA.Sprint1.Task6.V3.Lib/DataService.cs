using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.WarkentinMA.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string res = "";
            foreach (string word in value.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                res += word[word.Length - 1];

            }
            return res;

        }
    }
}
