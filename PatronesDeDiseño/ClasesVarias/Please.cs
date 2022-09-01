using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.ClasesVarias
{
    public static class Please
    {
        static string padding = "    ";

        public static void WriteWithTop(string text)
        {
            Console.WriteLine();
            Console.WriteLine(padding + text);
        }

        public static void WriteLine(string text)
        {
            Console.WriteLine(padding + text);
        }

        public static int AskToUser()
        {
            int numericValue;
            bool isNumber = int.TryParse(Console.ReadLine(), out numericValue);
            Console.Clear();

            return isNumber ? numericValue : -1;
        }

        public static void Wait()
        {
            Console.ReadKey();
            Console.Clear();
        }

        public static void GiveMePadding()
        {
            Console.Write(padding);
        }

        public static void WriteExteption(Exception ex)
        {
            Console.WriteLine(padding + ex.Message);
        }
    }
}
