// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Console.Clear();


int[,] GetArray2(int m, int n, int minValue, int maxValue)
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
void PrintArray2(int[,] inarray)
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
int[] GetArray1(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        if (i == size - 1) Console.Write($"{res[i]}");
        else Console.Write($"{res[i]} , ");
    }
    Console.WriteLine();
    return res;
}
void PrintArray1(int[] inarray)
{
    for (int i = 0; i < inarray.Length; i++)
    {
        Console.Write($"{inarray[i]} ");
    }
    Console.WriteLine();
}
int[,] CountNumbers2(int[,] array)
{
    int rows = array.GetLength(0);
    int colomns = array.GetLength(1);
    int min = 0;
    int max = 9;
    int[,] count = new int[2, 10];
    for (int k = min; k <= max; k++)
    {
        count[0, k] = k;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colomns; j++)
            {
                if (array[i, j] == k)
                {
                    count[1, k] += 1;
                }
            }
        }
    }
    return count;
}
int[,] CountNumbers1(int[] array)
{
    int min = 0;
    int max = 9;
    int[,] count1 = new int[2, 10];
    for (int k = min; k <= max; k++)
    {
        count1[0, k] = k;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == k)
            {
                count1[1, k] += 1;
            }
        }
    }
    return count1;
}
int[,] array2 = GetArray2(2, 3, 0, 3);
int[,] countArray2 = CountNumbers2(array2);
void PrintArrayWithName (int[,] arrayToName)
{
    int rows = arrayToName.GetLength(0);
    int colomns= arrayToName.GetLength(1);
    for (int l = 0; l < colomns; l++)
    {
        if (arrayToName[1,l] != 0) Console.WriteLine($"{arrayToName[0,l]} встречаеться {arrayToName[1,l]} раз(а)");
    }
}

PrintArray2(array2);
Console.WriteLine();
PrintArrayWithName(countArray2);
Console.WriteLine();

int[] array1 = GetArray1(3 , 0 , 4);
int[,] countarray1 = CountNumbers1(array1);

// PrintArray1(array1);
Console.WriteLine();
PrintArrayWithName(countarray1);
Console.WriteLine();