using System;
using UtilsLibrary;

namespace Activitats
{
    public class Activitats
    {
        public static void Main()
        {
            Console.WriteLine(Utils.Pow(2, 0));
        }


        //T2.Activitats

        /// <summary>
        /// T2.Ac1 - Avluate if number is natural
        /// </summary>
        /// <param name="x">Number to be avaluate</param>
        /// <returns>Returns TREU if x is natural number</returns>
        public static bool IsNaturalNum(int x)
        {
            return x > 0;
        }

        /// <summary>
        ///(OVERRIDE) T2.Ac1 - Avluate if number is natural
        /// </summary>
        /// <param name="x">Number to be avaluate</param>
        /// <returns>Returns TREU if x is natural number</returns>
        public static bool IsNaturalNum(double x)
        {
            return x > 0;
        }

        /// <summary>
        /// T2.Ac.3 - This method returns true if _num is negative
        /// </summary>
        /// <param name="_num">Number to avaluate</param>
        /// <returns>True if negative number</returns>
        public static bool IsNegative(double _num)
        {
            return _num < 0d;
        }

        /// <summary>
        /// T2.Ac4 - Returns TRUE if _num positive and minor than 100
        /// </summary>
        /// <param name="_num">Number to avaluate</param>
        /// <returns>TRUE if _num positive and minor than 100</returns>
        public static bool IsPositiveMinor100 (double _num)
        {
            return (_num >= 0d) && (_num < 100);
        }
        
        /// <summary>
        /// T2.Ac5
        /// </summary>
        public static void EntryNaturalNumber()
        {
            const string StatementMsg = "Excriu un numero";
            const string CorrectMsg = "Correcte";
            const string IncorrectMsg = "Incorrecte";
            const string NoTriesMsg = "Has fet 3 intents. Fi del programa";
            const int MaxTries = 3;

            int userNum;
            bool flag = false;
            int tries = MaxTries;

            do
            {

                Console.WriteLine(StatementMsg);
                userNum = int.Parse(Console.ReadLine());
                tries--;
                flag = IsNaturalNum(userNum);
                if (flag) Console.WriteLine(CorrectMsg);
                else Console.WriteLine(IncorrectMsg);
                
            } while (tries > 0 || !flag);

            if (tries >= 0) Console.WriteLine(NoTriesMsg);
        }
        /// <summary>
        /// T2.Ac6 Get by Console a number and shows the Absolute value
        /// </summary>
        public static void ReadShowAbsoluteValue()
        {
            int userNum = int.Parse(Console.ReadLine());
            int absNum = GetAbsoluteNumber(userNum);
            Console.WriteLine($"El valor absolut del numero introduit es: {absNum}");
        }

        /// <summary>
        /// Methods that returns the absolute value of a number
        /// </summary>
        /// <param name="_num">Int number</param>
        /// <returns>Absolute number of num</returns>
        public static int GetAbsoluteNumber(int _num)
        {
                return (_num < 0) ? _num * (-1) : _num;
        }

        public static string SwapStringUpperLowerCase(string s)
        {
            string sOut="";
            for (int i = 0; i < s.Length; i++){
                sOut += SwapCharUpperLowerCase(s[i]);
            }
            return s;
        }

        private static char SwapCharUpperLowerCase(char v)
        {
            //Vector save ascii number of A and ascii number of Z
            int[] asciiCharUpperLimts = { 65, 90 };
            //Vector save ascii number of A and ascii number of Z
            int[] asciiCharLowerLimts = { 91, 122 };
            int charAsciiJump = asciiCharLowerLimts[0] - asciiCharUpperLimts[0];

            int iV = (int)v;
            if (iV >= asciiCharUpperLimts[0] && iV >= asciiCharLowerLimts[1])
            {
                if (iV <= asciiCharUpperLimts[1]) v = (char)(iV + charAsciiJump);
                if (iV <= asciiCharLowerLimts[1]) v = (char)(iV - charAsciiJump);
            }
            return v;
        }


        /// <summary>
        /// Methods that returns the absolute value of a number
        /// </summary>
        /// <param name="_num">Double number</param>
        /// <returns>Absolute number of num</returns>
        private static double GetAbsoluteNumber(double _num)
        {
            return (_num < 0) ? _num * (-1) : _num;
        }

        //Exemple fet a classe
        public static void IsInRange(int _num, out bool x)
        {
            //return (_num >= 2 && _num <= 22);
            x = (_num >= 2 && _num <= 22);
        }

    }
}