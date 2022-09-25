// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




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

int[,] CompositionArray(int[,] arra1, int[,] arra2)
{
    int[,] ResultArray = new int[rows, colomns];
    if (((arra1.GetLength(0)) == arra2.GetLength(0)) && ((arra1.GetLength(1)) == (arra2.GetLength(1))))
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colomns; j++)
            {
                ResultArray[i, j] = arra1[i, j] * arra2[i, j];
            }
        }
        return ResultArray;
    }
    else
    {
        Console.WriteLine("Эти массивы нельзя полностью перемножить");
        int[,] EmptyArray = { };
        return EmptyArray;
    }
}


Console.WriteLine("первый массив");
int[,] array1 = GetArray(rows, colomns, minValue: 1, maxValue: 5);
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Второй массив");
int[,] array2 = GetArray(rows, colomns, minValue: 1, maxValue: 5);
PrintArray(array2);
Console.WriteLine();
Console.WriteLine("Произведенние массивов");
int[,] resultArrray = CompositionArray(array1, array2);
PrintArray(resultArrray);