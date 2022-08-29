/*
Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.
*/

Console.Clear();
Console.Write("Введите количество строк в массиве= ");
int n=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве= ");
int m=Convert.ToInt32(Console.ReadLine());

int[,] array=NewArray(n,m,0,20);
PrintArray(array);
Console.WriteLine();

int[,] NewArray(int n, int m, int min, int max)
{
    int[,] array=new int[n,m];
    for (int i=0; i<n;i++)    {
        for (int j=0;j<m;j++)        {
            array[i,j]=new Random().Next(min,max);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)    {
        for (int j=0;j<array.GetLength(1);j++)        {
            Console.Write($"  {array[i,j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] SwapArrayRows(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
            {
                int temp = array[0, j];
                array[0, j]=array[array.GetLength(0)-1, j];
                array[array.GetLength(0)-1, j] = temp;
            }
            return array;
}
SwapArrayRows(array);
PrintArray(array);