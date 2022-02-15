
using System.Collections.Generic;
using System.IO;

namespace cs28_paskaita_ExtensionMethods
{
    public static class Solution_01
    {
        // Parašykite extension metodą sveikiesiems skaičiams, kuris grąžins bool tipo kintamąjį nusakantį ar skaičius buvo teigiamas ar ne.
        public static bool EvalueteIfGivenIntegerIsMoreThan0(this int input)
        {
            if (input>=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Parašykite extension metodą sveikiesiems skaičiams, kuris grąžins bool tipo kintamąjį nusakantį ar skaičius buvo lyginis ar ne.
        public static bool EvalueteIfGivenIntegerDividesBy2(this int input)
        {
            if (input % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Parašykite extension metodą sveikiesiems skaičiams, kuris grąžins bool tipo kintamąjį nusakantį ar skaičius perduotas per parametrą yra didesnis ar ne.
        public static bool IsFirstNumberBiggerThanSecondOne(this (int, int) input)
        {
            if (input.Item1 > input.Item2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Parašykite extension metodą string tipui, kuris grąžins bool tipo kintamąjį nusakantį ar sakinyje yra tarpų ar ne.
        public static bool IsWhiteSpacesPresent(this string input)
        {
            char whiteSpace = ' ';
            if (input.Contains(whiteSpace))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Parašykite extension metodą string tipui su parametrais fullname, yearOfBirth ir domain,
        // metodas grąžins rezultatą kaip el.pašto adresą. Pvz.: “vardenispavardenis1990 @gmail.com”
        public static string ConcatStringsIntoAnEmail(this (string, string, string, string) input)
        {
            return $"{input.Item1}{input.Item2}{input.Item3}@{input.Item4}.com";
        }
        public static string ConcatStringsIntoAnEmailTurbo(this string input)
        {
            string[] inputArrayList = input.Split(", ");
            return $"{inputArrayList[0]}{inputArrayList[1]}{inputArrayList[2]}@{inputArrayList[3]}.com";
        }

        // Parašykite extension metodą FindAndReturnIfEqual List<T> tipui,
        // kuris priimtu T tipo objektą kaip parametrą ir grąžintų tokį patį, jeigu sąraše jis egzistuoja.
        public static T FindAndReturnIfEqual<T>(this List<T> list, T input)
        {
            int counter = 0;
            foreach (T item in list)
            {
                if (item.Equals(input))
                {
                    counter++;
                }
            }
            if (counter > 0)
            {
                return input;
            }
            else
            {
                return default; // <-- 40 min kol supratau, kaip gražinti Generic tuščią
            }
        }

        // Parašykit extension metodą EveryOtherWord List<T> tipui, kuris grąžintų sąrašą sudaryta iš kas antro elemento.
        public static List<T> RemoveEverySecondListItem<T>(this List<T> list)
        {
            int indexer = 2;
            var list2 = new List<T>();
            foreach (var item in list)
            {
                if (indexer % 2 == 0)
                {
                    list2.Add(item);
                }
                indexer++;
            }
            //System.Console.WriteLine("Sąrašas prieš metotą:");
            //foreach (var item in list)
            //{
            //    System.Console.Write($"{item}, ");
            //}
            //System.Console.WriteLine();
            //System.Console.WriteLine("Sąrašas po metodo:");
            //foreach (var item in list2)
            //{
            //    System.Console.Write($"{item}, ");
            //}
            //System.Console.WriteLine();
            return list2;
        }

        // Ar pavyktų sukurti extension metodų System.IO.File klasėi? Pavyzdžiui norint sukurt funkcionalumą grąžinantį kas antrą eilutę iš tekstinio failo.
        //public List<int> ReadData()
        //{
        //    string path = $@"D:\GitHub\cs27_paskaita_ExceptionHandling\cs27_paskaita_ExceptionHandling\Rinkmena.csv";
        //    var CSVLineReader = new StreamReader(path);

        //    while (!CSVLineReader.EndOfStream)
        //    {
        //        var line = CSVLineReader.ReadLine();
        //    }
        //    return FileDataInAList;
        //}

        // (!) Path is static, and therefore you cannot create an extension method for it.Extension methods require an instance of an object.
        // (!) You can't create extension method for static class.
    }

    //public static class StringExtensions
    //{
    //    public static int WordCount(this string str) // <-- čia this nutaiko į objektą iš kurio kviečiama
    //{
    //    return str.Split(new char[] { ' ', '.', '?', }, StringSplitOptions.RemoveEmptyEntries).Length;
    //}
    //}
}
