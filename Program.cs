using System;

namespace IterateA
{

    public class IterateA
    {
        public int IterateAtoX(int a, int x)
        {
            
            int asum = 0;
            for (int i = 1; i <= (x % a); i++)
            {

                asum = a * i;
                if ((asum + a) >= x)
                {
                    break;
                }
            }

            return asum;
        }

        public int IterateAplus1to2X(int a, int x)
        {
           
            int asum = 0;
            for (int i = 1; i <= (x % (a+1)); i++)
            {

                asum = (a+1) * i;
                if ((asum + a + 1) >= 2*x)
                {
                    break;
                }
            }

            return asum;
        }

        public int IterateAplus2to3X(int a, int x)
        {
            
            int asum = 0;
            for (int i = 1; i <= (x % (a + 1)); i++)
            {

                asum = (a + 2) * i;
                if ((asum + a +2) >= 3*x)
                {
                    break;
                }
            }

            return asum;
        }
    }











    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
