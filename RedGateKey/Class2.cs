using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RedGateKey
{
    internal class Class2
    {
        internal Class2(string string_1)
        {
            this.string_0 = string_1;
        }

        
        private bool method_0(char char_1, char char_2)
        {
            return char_1 == this.string_0[2] && char_2 == this.string_0[3];
        }

        
        private static void smethod_0(StringBuilder stringBuilder_0)
        {
            stringBuilder_0[2] = '0';
            stringBuilder_0[3] = '0';
        }

        
        public static void smethod_1(string string_1, out char char_1, out char char_2)
        {
            uint num = Class1.smethod_0(string_1);
            char_1 = Class2.smethod_2((byte)((ulong)num % (ulong)((long)Class2.char_0.Length)));
            char_2 = Class2.smethod_2((byte)((ulong)num / (ulong)((long)Class2.char_0.Length) % (ulong)((long)Class2.char_0.Length)));
        }

        
        public static char smethod_2(byte byte_0)
        {
            return Class2.char_0[(int)byte_0 % Class2.char_0.Length];
        }

        
        public override string ToString()
        {
            return this.string_0;
        }

        
        public bool Boolean_0
        {
            get
            {
                if (string.IsNullOrEmpty(this.string_0))
                {
                    return false;
                }
                string text = string.Format("[{0}]", new string(Class2.char_0));
                return new Regex(string.Concat(new string[]
                {
                "^A3",
                text,
                "{2}(-(",
                text,
                "{4})){5}$"
                })).IsMatch(this.string_0);
            }
        }

        
        public int Int32_0
        {
            get
            {
                return 3;
            }
        }

        
        public bool Boolean_1
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder(this.string_0);
                Class2.smethod_0(stringBuilder);
                char char_;
                char char_2;
                Class2.smethod_1(stringBuilder.ToString(), out char_, out char_2);
                return this.method_0(char_, char_2);
            }
        }

        
        private static readonly char[] char_0 = new char[]
        {
        '2',
        '3',
        '4',
        '6',
        '7',
        '8',
        '9',
        'A',
        'B',
        'C',
        'D',
        'E',
        'F',
        'G',
        'H',
        'J',
        'K',
        'M',
        'N',
        'P',
        'R',
        'T',
        'W',
        'X',
        'Y',
        'Z'
        };

        
        private readonly string string_0;
    }
}
