using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appQLNhaThuoc.Function_mide
{
    class MaHoa
    {
        public static string Encrypt(string inputStr)
        {
            int len = inputStr.Length;
            int sum = 10;
            StringBuilder sb = new StringBuilder(len);
            for (int i = 0; i < len; i++)
            {
                char c = (char)(inputStr[i] + sum);
                sb.Append(c);
            }
            return sb.ToString();
        }

        public static string Decrypt(string inputStr)
        {
            int len = inputStr.Length;
            int sum = 10;
            StringBuilder sb = new StringBuilder(len);
            for (int i = 0; i < len; i++)
            {
                char c = (char)(inputStr[i] - sum);
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
