/*
 - Задача 47: 
 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
 m = 3, n = 4.
 0,5 7 -2 -0,2
 1 -3,3 8 -9,9
 8 7,8 -7,1 9
*/

Console.Clear();
Console.Write("Введите количество строк массива m= ");
int n=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива n= ");
int m=Convert.ToInt32(Console.ReadLine());

double[,] array=GetArray(n,m,-10.00,10.00);
PrintArray(array);

double[,] GetArray(int m, int n, double min, double max)
{
    double[,] array=new double[m,n];
    for (int i=0; i<m;i++)
    {
        for (int j=0; j<n; j++)
        {
            array[i,j]=Math.Round((new Random().NextDouble()* (max - min) + min),1);
            //double random = new Random().NextDouble() * (max - min) + min;
            //array[i,j] = Math.Round(random, 2);    
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}