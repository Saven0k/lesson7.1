// адача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.Write("Введите колличество строк массива: ");
int rows = Math.Abs(int.Parse(Console.ReadLine()));

Console.Write("Введите колличество колоннок массива: ");
int colomns = Math.Abs(int.Parse(Console.ReadLine()));

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
void PrintArray(int[,] inarray)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            Console.Write($"{inarray[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[] MinSumInArray(int[,] arra)
{
    int[] result1 = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            result1[i] += arra[i, j];
        }
    }
    int count1 = 0;
    foreach (int i in result1)
    {
        count1++;
        Console.WriteLine($"{i} - сумма строки {count1}");
    }
    return result1;
}

void PrintAnswer(int[] arra)
{
    int min = arra[0];
    int count = 1;
    foreach ( int i in arra)
    {
        if (i < min)
        {
            min = i;
            count = count + 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($" У строки {count} наименьшая сумма ({min})");
}
int[,] array = GetArray(rows, colomns, 0, 9);
PrintArray(array);
Console.WriteLine();

Console.WriteLine();
int[] array1 = MinSumInArray(array);
PrintAnswer(array1);

