using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedGateKey
{
    internal class Class3
    {
        public static string smethod_0()
        {
            switch (Class5.int_0)
            {
                case 0:
                    return Class3.smethod_1();
                case 1:
                    return Class3.smethod_2();
                case 2:
                    return Class3.smethod_3();
                default:
                    return "Hey there!";
            }
        }

        
        public static string smethod_1()
        {
            Random random = new Random();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("LZ-{0}-{1}-", Class3.string_0[random.Next() & Class3.string_0.Length], Class3.string_0[random.Next() & Class3.string_0.Length]);
            stringBuilder.AppendFormat("{0}", random.Next(10000, 100000));
            stringBuilder.AppendFormat("-{0:X4}", Class1.smethod_0(stringBuilder.ToString()));
            return stringBuilder.ToString();
        }

        
        public static string smethod_2()
        {
            Random random = new Random();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{0}-{1}-", random.Next(100, 1000), random.Next(100, 1000));
            stringBuilder.AppendFormat("{0}", random.Next(100000, 1000000));
            stringBuilder.AppendFormat("-{0:X4}", Class1.smethod_0(stringBuilder.ToString()));
            return stringBuilder.ToString();
        }

        
        public static string smethod_3()
        {
            StringBuilder stringBuilder = new StringBuilder("A300");
            byte[] array = new byte[20];
            Random random = new Random();
            random.NextBytes(array);
            for (int i = 0; i < 5; i++)
            {
                stringBuilder.AppendFormat("-{0}{1}{2}{3}", new object[]
                {
                Class2.smethod_2(array[i * 4]),
                Class2.smethod_2(array[i * 4 + 1]),
                Class2.smethod_2(array[i * 4 + 2]),
                Class2.smethod_2(array[i * 4 + 3])
                });
            }
            char value;
            char value2;
            Class2.smethod_1(stringBuilder.ToString(), out value, out value2);
            stringBuilder[2] = value;
            stringBuilder[3] = value2;
            return stringBuilder.ToString();
        }

        
        private static string string_0 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    }
}
