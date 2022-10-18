namespace ConsoleApp101996
{
    public static class Condition
    {
        public static int ConditionOne(int a,int b) //1
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
        public static void ConditionTwo(int x,int y) //2
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Tocka naxoditsa v 1 cetverti");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Tocka naxoditsa vo 4 cetverti");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Tocka naxoditsa v 3 cetverti");
            }
            else
            {
                Console.WriteLine("Tocka naxoditsa v 2 cetverti");
            }
            
        }

        
        }
    }
}
    

