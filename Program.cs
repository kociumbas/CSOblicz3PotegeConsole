using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // wyświetla komunikat dla użytkownika i wstawia 2 puste wiersze
            Console.WriteLine("Program oblicza trzecią potęgę podanej liczby \n\n");

            //deklaracja zmiennych: x, x2, x3, wynik
            int x, x2, x3, wynik = 0;

            //wczytanie potęgowanej liczby
            Console.Write("Podaj liczbę: ");
            x = Convert.ToInt32(Console.ReadLine());

            //obliczenie kwadratu podanej liczby
            x2 = x * x;
            x3 = x2 * x;
            wynik = x3;

            Console.WriteLine("\n\n");

            //wyświetlenie obliczonego wyniku
            Console.WriteLine("Obliczona potęga wynosi:" + wynik);
            Console.WriteLine("\n\n\n Naciśnij ENTER, aby zakończyć program");
            Console.ReadLine();


        }
    }
}
