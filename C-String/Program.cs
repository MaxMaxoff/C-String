using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// http://ejudge.1gb.ru/cgi-bin/new-register?contest_id=9
/// C-String
/// 
/// На вход программы подаются произвольные алфавитно-цифровые символы. Ввод этих символов заканчивается точкой.
/// Требуется написать программу, которая будет печатать последовательность строчных английских букв('a' 'b'... 'z') из входной последовательности и частот их повторения.
/// Печать должна происходить в алфавитном порядке.Например, пусть на вход подаются следующие символы:
/// fhb5kbfыshfm.
/// В этом случае программа должна вывести
/// b2
/// f3
/// h2
/// kl
/// ml
/// s1
/// </summary>
namespace C_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // according to ASCII Alphabet Characters first symbol "a" has 97 decimal value
            const int convert = 97;
            const int alphabet = 26;
            int[] ch = new int[alphabet];

            //Prepare console
            Console.ForegroundColor = ConsoleColor.Green;

            //get string
            string str = Console.ReadLine();

            //make frequency array of chars
            foreach (char c in str)
            {
                if ((int)c >= convert && (int)c < convert + alphabet) ch[(int)c - convert]++;
            }

            //print out frequency array except element with 0 values
            for (int i = 0; i < alphabet; i++) if (ch[i] != 0) Console.WriteLine($"{(char)(i + convert)}{ch[i]}");

            Console.ReadKey();
        }
    }
}
