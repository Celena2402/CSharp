/*
Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
*/
Console.Clear();
Console.Write("Введите количество строк в массиве= ");
int n=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве= ");
int m=Convert.ToInt32(Console.ReadLine());

int[,] array=NewArray(n,m,1,10);
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
            Console.Write($"{array[i,j]}\t ");
        }
        Console.WriteLine();
    }
}

void MinNumber(int[,] array)
{
   // int min=0;
    for (int i=0; i<n;i++)    {
        for (int j=0;j<m;j++)     {
            int min=array[1,1];
            if (array[i,j]<min) {
                min=array[i,j];
            }
        }
    }
    //return array;
    Console.WriteLine($"min={min}");
}

MinNumber(array);
