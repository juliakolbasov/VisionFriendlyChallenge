using System;
using System.Linq;
using System.Numerics;

namespace Problem1
{
    public static class IntAddition
    {
        public static BigInteger getSum(Object[] arr)
        {
            BigInteger sum = 0;
            try
            {
                if (arr != null)
                {
                    foreach (var item in arr)
                    {
                        if (item != null && item.GetType() == typeof(int))
                        {
                            sum = sum + (int)item;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return sum;
        }
    }
}
