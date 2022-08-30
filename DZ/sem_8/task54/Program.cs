/*
Задача 54: 
   Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
   каждой строки двумерного массива.
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
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{    
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {          
            for (int k=0;k<array.GetLength(1)-1;k++)
            {
                if(array[i,k]<array[i,k+1])
                {
                    int temp=array[i,k+1];
                    array[i,k+1]=array[i,k];
                    array[i,k]=temp;
                }
            }
            
        }
    }
}

Console.Write("Введите количество строк в массиве= ");
int m=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве= ");
int n=Convert.ToInt32(Console.ReadLine());

int[,] array=NewArray(m,n,0,20);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Отсортированный масив:");
SortArray(array);
PrintArray(array);
