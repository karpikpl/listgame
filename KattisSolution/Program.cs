using System;
using System.Diagnostics;
using System.IO;
using KattisSolution.IO;

namespace KattisSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Solve(Console.OpenStandardInput(), Console.OpenStandardOutput());
        }

        public static void Solve(Stream stdin, Stream stdout)
        {
            IScanner scanner = new OptimizedIntReader(stdin);
            // uncomment when you need more advanced reader 
            // scanner = new Scanner(stdin);
            BufferedStdoutWriter writer = new BufferedStdoutWriter(stdout);

            var input = scanner.NextInt();

            int result = SimpleSolution(input);

            writer.Write(result);
            writer.Write("\n");
            writer.Flush();
        }

        private static int SimpleSolution(int input)
        {
            Debug.Write(input + " = ");
            var sqrt = Math.Sqrt(input);

            var result = 0;

            if (input != 2)
                while (input % 2 == 0)
                {
                    result++;
                    input /= 2;
                    Debug.Write("2 * ");
                }

            var a = 3;

            while (a <= sqrt)
            {
                if (input % a == 0)
                {
                    input /= a;
                    result++;
                    Debug.Write(a + " * ");
                }
                else
                {
                    a += 2;
                }
            }

            if (input != 1)
            {
                result++;
                Debug.Write(input);
            }

            Debug.WriteLine(" !");
            return result;
        }
    }
}
