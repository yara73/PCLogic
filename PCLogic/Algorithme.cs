using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCLogic
{
    class Algorithme
    {
        public string Inversion(double numb)
        {
            char[] numbChar = numb.ToString().ToCharArray();
            string numbString = "";
            for (int i = 0; i < numbChar.Length; i++)
            {
                numbChar[i] = (numbChar[i] > '0') ? '1' : '0';
                numbString += numbChar[i];
            }

            return numbString;
        }
    }
}
