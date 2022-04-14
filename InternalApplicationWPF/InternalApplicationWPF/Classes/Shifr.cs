using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalApplicationWPF.Classes
{
    internal class Shifr
    {
        private static byte[] key = new byte[] { 10, 11, 23, 23 };
        public static string XOR(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result += (char)str[i] ^ key[i % key.Length];
            }

            return result;
        }
    }
}
