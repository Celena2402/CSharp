/*
Задача 58: 
   Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/
/*
Матрицы A и B  могут быть перемножены, если они совместимы 
в том смысле, что число столбцов матрицы A(l*m) равно числу строк B (m*n)
матрица C  размерностью l × n 

*/

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
            Console.Write($"  {array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void MultiplicationTwoMatrices (int[,] arrayOne, int[,] arrayTwo, int[,] arrayThree)
{
    for (int i=0; i<arrayOne.GetLength(0);i++)
    {
        for (int j=0; j<arrayTwo.GetLength(1);j++)
        {
            int sum=0;
            for (int k=0; k<arrayOne.GetLength(1);k++)
            {
                sum=sum+arrayOne[i,k]*arrayTwo[k,j];
            }
            arrayThree[i,j]=sum;
        }
    }    
}

Console.Write("Введите количество строк в матрице А: l= ");
int l=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в матрице А: m= ");
int m=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество строк матрицы В должно быть равно количеству столбцов матрицы А: m= {m}");
Console.Write("Введите количество столбцов в матрице В: n= ");
int n=Convert.ToInt32(Console.ReadLine());

int[,] arrayOne=NewArray(l,m,0,10);
int[,] arrayTwo=NewArray(m,n,0,10);
int[,] arrayThree=new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
Console.WriteLine("Первая матрица А:");
PrintArray(arrayOne);
Console.WriteLine();

Console.WriteLine("Вторая матрица В:");
PrintArray(arrayTwo);
Console.WriteLine();

Console.WriteLine("Произведение матриц А и В :");
MultiplicationTwoMatrices(arrayOne,arrayTwo, arrayThree);
PrintArray(arrayThree);