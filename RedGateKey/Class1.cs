using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RedGateKey
{
    internal class Class1
    {
        public static uint smethod_0(string string_0)
        {
            long num = 0L;
            foreach (int num2 in string_0)
            {
                for (int j = 7; j >= 0; j--)
                {
                    bool flag = (num & 32768L) == 32768L ^ (num2 & 1 << j) != 0;
                    num = (num & 32767L) << 1;
                    if (flag)
                    {
                        num ^= 4129L;
                    }
                }
            }
            return (uint)num;
        }

        
        public static string smethod_1(int int_0, int int_1, int int_2)
        {
            string text = string.Format("{0:X4}-{1:X4}-{2:X4}", int_0, int_1, int_2);
            return string.Format("{0}-{1:X4}", text, Class1.smethod_0(text));
        }

        
        public static string smethod_2(string string_0, string string_1, string string_2)
        {
            string text = string.Format("{0:X4}-{1:X4}-{2:X4}", Class1.smethod_0(string_0), Class1.smethod_0(string_1), Class1.smethod_0(string_2));
            return string.Format("{0}-{1:X4}", text, Class1.smethod_0(text));
        }

        
        public static bool smethod_3(string string_0, string string_1)
        {
            return Class1.smethod_4(string_0) && Class1.smethod_4(string_1) && (!(string_0.Substring(0, 4) != string_1.Substring(0, 4)) || !(string_0.Substring(5, 4) != string_1.Substring(5, 4)) || !(string_0.Substring(10, 4) != string_1.Substring(10, 4)));
        }

        
        public static bool smethod_4(string string_0)
        {
            if (string.IsNullOrEmpty(string_0))
            {
                return false;
            }
            string_0 = string_0.ToUpperInvariant().Trim();
            if (!Class1.regex_0.IsMatch(string_0))
            {
                return false;
            }
            string string_ = string_0.Substring(0, 14);
            string value = string.Format("{0:X4}", Class1.smethod_0(string_));
            return string_0.EndsWith(value);
        }

        
        private static Regex regex_0 = new Regex("^[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}$", RegexOptions.Compiled);
    }
}
