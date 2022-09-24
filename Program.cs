// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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
int[,] ChangeRows(int[,] arra)
{
    int[,] result1 = arra; 
    int[] changeBox = new int[colomns];
    for (int i = 0; i < colomns; i++)
    {
        changeBox[i] = arra[0,i];
        result1[0,i] = arra[arra.GetLength(0)-1, i];
        arra[arra.GetLength(0)-1, i] = changeBox[i];
    }
    return result1;
}
int[,] array = GetArray(rows, colomns, minValue: 1, maxValue: 10);
PrintArray(array);
Console.WriteLine(     );
int[,] array2 = ChangeRows(array);
PrintArray(array2);