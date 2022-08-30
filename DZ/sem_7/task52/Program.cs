/*
 - Задача 52: 
 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
 столбце.
 Например, задан массив:
 1 4 7 2
 5 9 2 3
 8 4 2 4
 Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
*/
Console.Clear();
Console.Write("Введите количество строк в массиве= ");
int m=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве= ");
int n=Convert.ToInt32(Console.ReadLine());

int[,] array=NewArray(m,n,0,10);
PrintArray(array);

int[,] NewArray(int m, int n, int min, int max)
{
    int[,] array=new int[m,n];
    for (int i=0; i<m;i++)
    {
        for (int j=0;j<n;j++)
        {
            array[i,j]=new Random().Next(min,max);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void MeanOfColumns (int[,] array) {
    double sum=0;
    double result=0;
    for (int j=0; j<array.GetLength(1);j++) 
    {
        for (int i=0; i<array.GetLength(0);i++) 
        {
            //Console.Write($" {array[i, j]} ");
            sum=(sum+array[i,j]);        

        }
        result=Math.Round((sum/array.GetLength(0)),2);
        Console.WriteLine($"Среднее арифметическое [{j+1}]  столбца = {result}");
        sum=0;
    }
    //return sum;
} 
Console.WriteLine();
MeanOfColumns(array);

