using System;
using System.Collections.Generic;

namespace cs28_paskaita_ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs28_PASKAITA_ExtensionMethods!");
            #region TEORIJA - EXTENSION METHODS
            // Extension metodas leidžia pridėti nauj1 funkcionalum1 prie jau egzistuojan2io tipo;
            // Extension metodai kvie2iami ant extendinamo tipo;
            int x = 0;
            // Kas yra instance metodai? Kaip jie kviečiami?  Bus kviečiami per objektą klasės.
            // Duomenų tipo papildymas nauju funkcionalumu

            // Extension metodai aprašomi kaip statiniai, bet kviečiami kaip instance tipo metodai.
            // This referuoja į esamą instance klasės ir taip pat kaip modyfier pirmam paremetro metodui;

            string s = "55555 4444 333 22 1";
            Console.WriteLine(s.WordCount());
            #endregion

            #region Solution_01
            // Parašykite extension metodą sveikiesiems skaičiams, kuris grąžins bool tipo kintamąjį nusakantį ar skaičius buvo teigiamas ar ne.
            Console.WriteLine($"Skaičius yra teigiamas? 10: {10.EvalueteIfGivenIntegerIsMoreThan0()}");
            Console.WriteLine($"Skaičius yra teigiamas? 0: {0.EvalueteIfGivenIntegerIsMoreThan0()}");
            Console.WriteLine($"Skaičius yra teigiamas? -5: {(-5).EvalueteIfGivenIntegerIsMoreThan0()}");
            Console.WriteLine();

            // Parašykite extension metodą sveikiesiems skaičiams, kuris grąžins bool tipo kintamąjį nusakantį ar skaičius buvo lyginis ar ne.
            Console.WriteLine($"Ar skaičius yra sveikojo tipo? 10: {(10).EvalueteIfGivenIntegerDividesBy2()}");
            Console.WriteLine($"Ar skaičius yra sveikojo tipo? 5: {(5).EvalueteIfGivenIntegerDividesBy2()}");
            Console.WriteLine();

            // Parašykite extension metodą sveikiesiems skaičiams, kuris grąžins bool tipo kintamąjį nusakantį ar skaičius perduotas per parametrą yra didesnis ar ne.
            Console.WriteLine($"Ar pirmas skaičius didesnis už antrą? 1, 2: {(1, 2).IsFirstNumberBiggerThanSecondOne()}");
            Console.WriteLine($"Ar pirmas skaičius didesnis už antrą? 2, 1: {(2, 1).IsFirstNumberBiggerThanSecondOne()}");
            Console.WriteLine();

            // Parašykite extension metodą string tipui, kuris grąžins bool tipo kintamąjį nusakantį ar sakinyje yra tarpų ar ne.
            Console.WriteLine($"Ar sakinyje yra tarpų? Rytas Diena Vakaras: {("Rytas Diena Vakaras").IsWhiteSpacesPresent()}");
            Console.WriteLine($"Ar sakinyje yra tarpų? Rytas+Diena+Vakaras: {("Rytas+Diena+Vakaras").IsWhiteSpacesPresent()}");
            Console.WriteLine();

            // Parašykite extension metodą string tipui su parametrais fullname, yearOfBirth ir domain,
            // metodas grąžins rezultatą kaip el.pašto adresą. Pvz.: “vardenispavardenis1990 @gmail.com”
            Console.WriteLine($"Paduodu: 4 stringus: Vytautas, Surkus, 2000, whateva: {("Vytautas", "Surkus", "2000", "whateva").ConcatStringsIntoAnEmail()}");
            Console.WriteLine($"Paduodu: 1 stringą: 'Vytautas, Surkus, 2000, whateva': {("Vytautas, Surkus, 2000, whateva").ConcatStringsIntoAnEmailTurbo()}");

            // Parašykite extension metodą FindAndReturnIfEqual List<T> tipui,
            // kuris priimtu T tipo objektą kaip parametrą ir grąžintų tokį patį, jeigu sąraše jis egzistuoja.
            var list = new List<string>();
            list.Add("Diena");
            list.Add("Rytas");
            list.Add("Vakaras");

            Console.WriteLine($"Sąrašas: Diena, Rytas, Vakaras; Tikrinu Diena: {list.FindAndReturnIfEqual("Diena")}");
            Console.WriteLine($"Sąrašas: Diena, Rytas, Vakaras; Tikrinu Naktis: {list.FindAndReturnIfEqual("Naktis")}");

            // Parašykit extension metodą EveryOtherWord List<T> tipui, kuris grąžintų sąrašą sudaryta iš kas antro elemento.
            var list2 = new List<int>();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            list2 = list2.RemoveEverySecondListItem();
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            #endregion
        }

    }
    #region Extension metodo pavizdys
    public static class StringExtensions
    {
        public static int WordCount(this string str) // <-- čia this nutaiko į objektą iš kurio kviečiama
        {
            return str.Split(new char[] { ' ', '.', '?', }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
    #endregion
}
