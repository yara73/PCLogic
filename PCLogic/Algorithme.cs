using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCLogic
{
    class Algorithme
    {
        public string Inversion(int numb)
        {
            char[] numbChar = numb.ToString().ToCharArray();
            string numbString = "";
            for (int i = 0; i < numbChar.Length; i++)
            {
                numbChar[i] = (numbChar[i] > '0') ? '0' : '1';
                numbString += numbChar[i];
            }

            return numbString;
        }
        public string StraightCode(int numb)
        {
            return null;
        }
        public String floatDIG(double source, int destpoint)
        {
            string dest = "";
            char[] c = new char[destpoint + 3];
            for (int i = 0; i < destpoint; i++)
            {
                Console.Write("X[0]*" + source + "\t");
                source *= 2;
                c[i] = (source >= 1.0) ? '1' : '0';
                source -= (source >= 1.0) ? 1 : 0;
                dest += c[i];
                Console.WriteLine("Binary 0." + dest);

            }
            return dest;
        }
        public String convertNumSys(System.String s, System.Int32 inBase, System.Int32 outBase)
        {
            const System.String digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            System.String res = "";
            System.Int32 dig = 0;
            System.Int32 temp, basePower;
            temp = 0;
            basePower = 1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                dig = Convert.ToInt32(s[i]);
                if ((dig >= 48) && (dig <= 57))
                    dig = dig - 48;
                else
                {
                    if ((dig >= 65) && (dig <= 90))
                        dig = dig - 65;
                    else
                    {
                        if ((dig >= 97) && (dig <= 122))
                            dig = dig - 97;
                    }
                }
                temp = temp + dig * basePower;
                basePower = basePower * inBase;
            }
            res = "";
            while (temp != 0)
            {
                Console.Write("Digit: " + temp + "\t");
                dig = temp % outBase;
                res = digits[dig] + res;
                temp = temp / outBase;
                Console.Write("Binary: " + dig + "\t");
                Console.Write("Code: " + res + "    ");
                Console.WriteLine();
            }
            return res;
        }
    }
}
