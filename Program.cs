using System;

namespace homework2103
{
    class Program
    {
        static void Main(string[] args)
        {
            {// ex #1
            double a = 16.80, b = 12.40;
            double c = Math.Sqrt(a*b);
            Console.WriteLine(c);
            
            }
            {// ex #2 
            double tochkaA = 1.40, tochkaB = -5.50, tochkaC = 0.60;
            double dlinaAC = Math.Abs(tochkaA - tochkaC);
            double dlinaBC = Math.Abs(tochkaB - tochkaC);
            double summaDlin = Math.Abs( dlinaAC + dlinaBC);
            Console.WriteLine(dlinaAC);
            Console.WriteLine(dlinaBC);
            Console.WriteLine(summaDlin);
            }
            {// ex #3 
            double x1 = -6.20, y1 = 5.20, x2 = 2.10, y2 = 9.80;
            double rMT = Math.Sqrt( Math.Pow((x1 - x2), 2) + Math.Pow((y1-y2),2));
            Console.WriteLine(rMT);
            }
            {// ex #4
            int chislo = 54;
            int decyatki = chislo/10;
            int edenisi = chislo % 10;
            int chisloNaoborot = edenisi*10+decyatki;
            Console.WriteLine(chisloNaoborot);
            }
            {// ex #5
            int sec = 10985;
            int min = sec/60;
            int hour = min/60;
            int day = hour/24;
            Console.WriteLine(min);
            }
            { // ex #6
            int nomerDnya = 202;
            int nomerNedeli = nomerDnya % 7;
            Console.WriteLine(nomerNedeli);
            }
        }
    }
}
