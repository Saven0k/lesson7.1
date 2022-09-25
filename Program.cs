// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

int[,] NumbersUp(int[,] arra)
{
    int[,] result1 = arra;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            for (int g = 0; g < colomns-1; g++)
            {
                if (arra[i, g] < arra[i, g+1])
                {
                    int temp = arra[i, g+1];
                    arra[i, g+1] = arra[i, g ];
                    result1[i, g] = temp;

                }
            }

        }
    }
    return result1;
}
int[,] array = GetArray(rows, colomns, 0, 9);
PrintArray(array);
Console.WriteLine();
int[,] array1 = NumbersUp(array);
PrintArray(array1);
