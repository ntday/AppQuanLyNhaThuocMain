using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace appQLNhaThuoc.Function_middleware
{
    class XoaDauTiengViet
    {
        string chuoiUTF8;
        public XoaDauTiengViet(string chuoiUTF8)
        {
           this.chuoiUTF8 = chuoiUTF8;
        }

        public string chuyenDoi()
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = chuoiUTF8.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }


    }
}
