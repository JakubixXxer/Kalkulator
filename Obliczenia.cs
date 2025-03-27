using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Prawde powiedziawszy nw czy to dziala bo robilem to troche na oko i nie sprawdzalem

namespace Kalkulator
{
    class Obliczenia
    {
        public static void TakeTwoNumbers(out int a, out int b)
        {
            while (true)
            {
                Console.WriteLine("Podaj a:");
                if (int.TryParse(Console.ReadLine(), out a)) break;
                Console.WriteLine("Błąd: Wpisz poprawną liczbę całkowitą.");
            }
        
            while (true)
            {
                Console.WriteLine("Podaj b:");
                if (int.TryParse(Console.ReadLine(), out b)) break;
                Console.WriteLine("Błąd: Wpisz poprawną liczbę całkowitą.");
            }
        }
        
        public static void Suma()
        {
            int a, b;
            TakeTwoNumbers(out a, out b);
            Console.WriteLine($"Wynik obliczenia to: {a + b}");
        }

        public static void Róznica()
        {
            int a, b;
            TakeTwoNumbers(out a, out b);
            Console.WriteLine($"Wynik obliczenia to: {a - b}");
        }

        public static void Iloczyn()
        {
            int a, b;
            TakeTwoNumbers(out a, out b);
            Console.WriteLine($"Wynik obliczenia to: {a * b}");
        }

        public static void Iloraz()
        {
            int a, b;
            TakeTwoNumbers(out a, out b);
            if(b == 0)
            {
                Console.WriteLine("Nie można podzielić przez 0!");
            }
            else
            {
                Console.WriteLine($"Wynik obliczenia to: {a / b}");
            }
        }

        public static void Potęga()
        {
            int liczba, potega;
            while (true)
            {
                Console.WriteLine("Podaj liczbe:");
                if (int.TryParse(Console.ReadLine(), out liczba)) break;
                Console.WriteLine("Błąd: Wpisz poprawną liczbę całkowitą.");
            }
            while (true)
            {
                Console.WriteLine("Podaj potege:");
                if (int.TryParse(Console.ReadLine(), out potega)) break;
                Console.WriteLine("Błąd: Wpisz poprawną liczbę całkowitą.");
            }

            int wynik = (int)Math.Pow(liczba, potega);
            Console.WriteLine($"Wynik obliczenia to: {wynik}");
        }

        public static void Pierwiastek()
        {
            int liczba;
            while (true)
            {
                Console.WriteLine("Podaj liczbe:");
                if (int.TryParse(Console.ReadLine(), out liczba)) break;
                Console.WriteLine("Błąd: Wpisz poprawną liczbę całkowitą.");
            }

            int wynik = (int)Math.Sqrt(liczba);
            Console.WriteLine($"Wynik obliczenia to: {wynik}");
        }

        public static void FunkcjaTrygometyczna()
        {
            int a, b, c;
            while (true)
            {
                Console.WriteLine("Podaj przyprostokatna:");
                if (int.TryParse(Console.ReadLine(), out a)) break;
                Console.WriteLine("Błąd: Wpisz poprawną liczbę całkowitą.");
            }
            while (true)
            {
                Console.WriteLine("Podaj przykatna:");
                if (int.TryParse(Console.ReadLine(), out b)) break;
                Console.WriteLine("Błąd: Wpisz poprawną liczbę całkowitą.");
            }
            while (true)
            {
                Console.WriteLine("Podaj przeciwprostokatna:");
                if (int.TryParse(Console.ReadLine(), out c)) break;
                Console.WriteLine("Błąd: Wpisz poprawną liczbę całkowitą.");
            }

            int sin = a / c;
            int cos = b / c;
            int tg = a / b;
            int ctg = b / a;
            //int sec = 1 / cos;
            //int csc = 1 / sin;
            // Tutaj jest problem z tym, że wszystko jest intem
            // sin i cos nie mogą przy dwóch ostatnich być równe 0

            Console.WriteLine($"Wynik obliczenia to: (sin = {sin}, cos = {cos}, tg = {tg}, ctg = {ctg}");
        }
    }
}
