using System;

namespace TaskService
{
    static public class MathService
    {
        
        static public int ReverseInteger(int x)
        {

            if (x >= Int32.MaxValue) return 0;

            var isNegative = x < 0;

            if (isNegative) x = x * -1;

            var strArray = x.ToString().ToCharArray();
            Array.Reverse(strArray);
            int result = 0;
            int.TryParse(new string(strArray), out result);

            if (isNegative) result = result * -1;

            return result;
        }

    }
}