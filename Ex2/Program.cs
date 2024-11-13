using System;
using UtilsLibrary;

namespace Ex2Cool
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(Utils.Pow(2, 0));
            int num = 0;
            bool flag;
            IsInRange(num, out flag);
        }

        public static void IsInRange(int _num, out bool x)
        {
            //return (_num >= 2 && _num <= 22);
            x = (_num >= 2 && _num <= 22);
        }

    }
}