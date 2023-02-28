using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Challenge1
{
    internal class Program
    {
        public static string[] ReverseArray(string[] strings)
        {
            int iterations = strings.Length/2;
            for(int i = 0; i < iterations; i++)
            {
                string primer_int = strings[i];
                strings[i] = strings[strings.Length - 1 - i];
                strings[strings.Length - 1 - i] = primer_int;

            }
            return strings;
        }
        static void Main(string[] args)
        {
            string[] prueba = { "3", "2", "1" };
            ReverseArray(prueba);
            Console.WriteLine(string.Join(" ",prueba));
        }
    }
}