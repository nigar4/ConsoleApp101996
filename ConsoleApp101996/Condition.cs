using System.Text;

namespace ConsoleApp101996
{
    public static class Condition
    {
        public static int ConditionOne(int a, int b) //1
        {
            if (a > b)
            {
                return a + b;
            }
            else if (a == b)
                return a * b;
            else
                return a - b;
        }
        public static string ConditionTwo(int x, int y) //2
        {
            StringBuilder result = new StringBuilder("Tocka naxoditsa");
            if (x > 0 && y > 0)
            {
                result.Append(" v 1 cetverti");
            }
            else if (x > 0 && y < 0)
            {
                result.Append(" vo 4 cetverti");
            }
            else if (x < 0 && y < 0)
            {
                result.Append(" v 3 cetverti");
            }
            else
            {
                result.Append(" v 2 cetverti");
            }
            return result.ToString();
        }



    }
}


