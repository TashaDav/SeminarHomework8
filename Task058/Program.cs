/*
Задать две матрицы. Написать программу, которая будет находить произведение двух
матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.WriteLine("Введите количество строк 1-го массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1-го массива: ");
int n = int.Parse(Console.ReadLine());
    
Console.WriteLine("Введите количество строк 2-го массива: ");
int m1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2-го массива: ");
int n1 = int.Parse(Console.ReadLine());

if (n != m1)
{
    Console.WriteLine("Такие матрицы умножать нельзя!");
    return;
}

int[,] A = GetArray(m, n, 0, 10);
int[,] B = GetArray(m1, n1, 0, 10);
Console.WriteLine();
PrintArray(A);
Console.WriteLine();
PrintArray(B);
Console.WriteLine();
PrintArray(GetMultiplicationMatrix(A,B));

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
      
     }
    return result;
    }

    void PrintArray(int[,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    int [,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
    {
        int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
        for (int i = 0; i < arrayA.GetLength(0); i++)
        {
            for (int j = 0; j < arrayB.GetLength(1); j++)
            {
                for (int k = 0; k < arrayA.GetLength(1); k++)
                {
                    arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
                }
            }
        }
      return arrayC;
    }