// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// Не получился и не знаю как сделать
Console.Clear();
Console.Write("Введите X: ");
int X = Math.Abs(int.Parse(Console.ReadLine()));

Console.Write("Введите Y: ");
int Y = Math.Abs(int.Parse(Console.ReadLine()));

Console.Write("Введите Z: ");
int Z = Math.Abs(int.Parse(Console.ReadLine()));

void PrintArray(int[,,] arra3D)
{
    Console.WriteLine();
    for (int i = 0; i < arra3D.GetLength(0); i++)
    {
        for (int j = 0; j < arra3D.GetLength(1); j++)
        {
            for (int g = 0; g < arra3D.GetLength(2); g++)
            {
                Console.WriteLine($"{arra3D[i, j, g]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,,] CreatArray(int x, int y, int z)
{
    int[,,] Array3d = new int[x, y, z];
    for (int i = 0; i < Array3d.GetLength(0); i++)
    {
        for (int j = 0; j < Array3d.GetLength(1); j++)
        {
            for (int g = 0; g < Array3d.GetLength(2); g++)
            {
                Array3d[i, j, g] = new Random().Next(10, 100);
            }
        }
    }
    return Array3d;
}
int[,,] array3 = CreatArray(X, Y, Z);
PrintArray(array3);