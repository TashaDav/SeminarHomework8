/*
Задать прямоугольный двумерный массив. Написать программу, которая будет находить
строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строку и выдает номер строки с наименьшей
суммой элементов: 1 строка.
*/

Console.WriteLine("Введите количесвто строк массива(m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива(n): ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArr = new int[m,n];

void array(int m, int n)
{
    int i,j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            randomArr[i,j] = rand.Next(1, 10);
        }
    }
}
void printm(int[,] array)
{
    int i,j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
array(m,n);
Console.WriteLine("Исходный массив: ");
printm(randomArr);
int SumLine(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
    return sum;
}
int minSum = 1;
int sum = SumLine(randomArr, 0);
for (int i = 1; i < randomArr.GetLength(0); i++)
{
    if (sum > SumLine(randomArr, i))
    {
        sum = SumLine(randomArr, i);
        minSum = i+1;
    }
}
Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");
