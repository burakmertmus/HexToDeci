using System;

namespace HexToDeci
{
    class Program
    {

        static void Main(string[] args)
        {

            while(0<1){
                Console.WriteLine("-------------");
                Console.WriteLine("Sayı Giriniz");
                string HexadecimalValue = Console.ReadLine();
                Console.WriteLine("Cevap:");
                Console.WriteLine(HexToDecimal(HexadecimalValue));
                Console.WriteLine("-------------"); 

            }

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
                else
                {
                    
                    Console.WriteLine("Hexadecimal olmayan karakter indisi:");
                    return i;
                    
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
