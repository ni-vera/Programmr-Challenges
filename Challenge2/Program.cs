using System.Text.RegularExpressions;

namespace Challenge2
{
    internal class Program
    {
        public static int OddSum(int limit)
        {
            int n = limit / 2;
            return Convert.ToInt32(Math.Pow(2,n))+2*(n-1) + n;
        }

        static void Main(string[] args)
        {
            string entrada_usuario = "a";
            while (!Regex.IsMatch(entrada_usuario,@"\d+")) 
            { 
            entrada_usuario = Console.ReadLine();
            }
            int entrada_convertida = int.Parse(entrada_usuario);
            string output = OddSum(entrada_convertida).ToString();
            Console.WriteLine(output);
        }
    }
}