namespace UtilsLibrary
{
    public class Utils
    {
        
        public static double Pow(double _base, int _exp)
        {
            double result = 1d;
            int expAbs = (_exp < 0) ? (-1) * _exp : _exp;

            if (_exp == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 0; i < expAbs; i++)
                {
                    result = result * _base;
                }
                result = (_exp > 0) ? result : 1 / result;
            }

            return result;
        }
    }
}
