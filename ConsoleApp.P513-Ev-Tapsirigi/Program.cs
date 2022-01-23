using System;

namespace ConsoleApp.P513_Ev_Tapsirigi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 22222;
            int b = 11111;
            int s = a % 10;


            int qaliq;

            int cem = 0;
            int hasil = 1;
            int netice;
            while (a > 0)
            {
                qaliq = a % 10;
                a = (a - qaliq) / 10;
                cem = cem + qaliq;
            }
            while (b > 0)
            {
                qaliq = b % 10;
                b = (b - qaliq) / 10;
                hasil = hasil * qaliq;
            }
            netice = hasil + cem;


            netice = netice * 10;
            s = netice + s;
            Console.WriteLine(s);
        }
    }
}
