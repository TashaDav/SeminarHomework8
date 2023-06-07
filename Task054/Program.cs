// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элемент каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1 
// 9 5 3 2
// 8 4 4 2

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[3, 4];
        Random random = new Random();
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(1, 10);
            }
        }
        
        Console.WriteLine("Исходный массив:");
        PrintArray(array);
        
        SortArray(array);
        
        Console.WriteLine("Отсортированный массив:");
        PrintArray(array); 
    }
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static void SortArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                for (int k = j + 1; k < array.GetLength(1); k++)
                {
                    if (array[i, j] < array[i, k])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }
    }
}