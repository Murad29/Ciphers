using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciphers.CaesarCipher
{
    class CaesarCipher
    {
        public string Encription(string text)
        {
            string cipherText = "";
            int n = 3;
            int x = 0;

            foreach (var item in text)
            {
                if (item != 32 && item != 160)
                {
                    x = item - n;
                    cipherText += Convert.ToChar(x);
                }
                else
                    cipherText += " ";
            }

            return cipherText;
        }
    }
}
