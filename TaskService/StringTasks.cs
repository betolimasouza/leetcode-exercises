using System;
using System.Collections.Generic;

namespace TaskService
{
    public static class StringTasks
    {
        public static int RomanToInt(string s)
        {
            var result = 0;

            var dic = new Dictionary<string, int>();
            dic.Add("I", 1);
            dic.Add("IV", 4);
            dic.Add("V", 5);
            dic.Add("IX", 9);
            dic.Add("X", 10);
            dic.Add("XL", 40);
            dic.Add("L", 50);
            dic.Add("XC", 90);
            dic.Add("C", 100);
            dic.Add("CD", 400);
            dic.Add("D", 500);
            dic.Add("CM", 900);
            dic.Add("M", 1000);

            char currChar = ' ';
            char nextChar = ' ';

            char[] array = s.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                currChar = array[i];
                if (i != array.Length - 1) nextChar = array[i + 1];

                int convertedNumber = 0;
                if (dic.TryGetValue(currChar.ToString() + nextChar.ToString(), out convertedNumber) == false)
                    dic.TryGetValue(currChar.ToString(), out convertedNumber);
                else
                    i++;

                result += convertedNumber;
            }

            return result;
        }
    }
}