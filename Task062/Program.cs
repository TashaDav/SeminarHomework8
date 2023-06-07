/*
Написать программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

class Program
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Введите размерность массива");
            n = Convert.ToInt32(Console.ReadLine());
            var a = GetSpire(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }
        private static int[,] GetSpire(int n)
        {
            var result = new int[n, n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    result[i, j] = rand.Next(n, n);
            for (int currentChar = 1, padding = 0; padding < n / 2; padding++)
            {
                for (int j = padding; j < n - padding; j++)
                    result[padding, j] = currentChar;
                for (int j = padding; j < n - padding; j++)
                    result[n - padding - 1, j] = currentChar;
                for (int i = padding + 2; i < n - padding - 1; i++)
                    result[i, padding] = currentChar;
                for (int i = padding + 1; i < n - padding - 1; i++)
                    result[i, n - padding - 1] = currentChar;
                currentChar = 1 - currentChar;
                result[padding + 1, padding] = currentChar;
            }
            if (n % 2 != 0 && result[0, 0] == 1)
                result[n / 2, n / 2] = 1;
            return result;
        }
    }




