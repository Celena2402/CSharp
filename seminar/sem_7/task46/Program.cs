/*
 Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
   m = 3, n = 4.
   1 4 8 19 
   5 -2 33 -2 
   77 3 8 1
*/

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int colums=int.Parse(Console.ReadLine());
int[,] array=GetArray(rows,colums,-20,20);
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result=new int[m,n];
    for (int i=0; i<m;i++)
    {
        for (int j=0; j<n; j++)
        {
            result[i,j]=new Random().Next(min,max);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
