// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя. 
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

int[,] ChangeRowsOnColoms(int[,] arra)
{
    int[,] result1 = new int[colomns,rows];
    int[,] result0 = {};
    if (rows == colomns)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colomns; j++)
            {
                result1[j,i] = arra[i,j];
            }
        }
        return result1;
    }
    else
    {
        Console.WriteLine("Поменять стороки на столбы невозможно");
        return result0;
    }
}
int[,] array = GetArray(rows, colomns, minValue: 1, maxValue: 10);
PrintArray(array);
Console.WriteLine();
int[,] arra1 = ChangeRowsOnColoms(array);
PrintArray(arra1);