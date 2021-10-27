using System;

namespace HexToDeci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Giriniz");
            string HexadecimalValue=Console.ReadLine();
            Console.WriteLine(HexToDecimal(HexadecimalValue));

        }
        private static int HexToDecimal(string Hex)
        {
            int deci = 0,value=0;

            for (int i = 0; i < Hex.Length; i++)
            {
                if (Hex[i] >= '0' && Hex[i] <= '9')
                {
                    value = Hex[i] - 48;
                }
                else if (Hex[i] >= 'a' && Hex[i] <= 'f')
                {
                    value = Hex[i] - 97 + 10;
                }
                else if (Hex[i] >= 'A' && Hex[i] <= 'F')
                {
                    value = Hex[i] - 65 + 10;
                }
                
                int a = 1;
                for (int j = 0; j < Hex.Length - i-1; j++)
                {
                    a *= 16;
                }

                deci += value*a;

            }
            return deci;
        }
        
    }
}
