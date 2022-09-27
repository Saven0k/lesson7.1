// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();
int i = 0;
int j = 0;
int g = 1;
int m = 4;
int[,] ZipArray = new int[m, m];
while (g <= 4 * 4)
{
  ZipArray[i,j] = g;
  g++;
  if (i <= j + 1 && i + j < m - 1)
    j++;
  else if (i < j && i + j >= m - 1)
    i++;
  else if (i >= j && i + j > m - 1)
    j--;
  else
    i--;
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
PrintArray(ZipArray);