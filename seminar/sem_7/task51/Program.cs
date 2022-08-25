/*
 - Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся 
 на главной диагонали (с индексами (0,0); (1;1) и т.д.
 Например, задан массив:
 1 4 7 2
 5 9 2 3
 8 4 2 4
 Сумма элементов главной диагонали: 1+9+2 = 12
*/

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int colums=int.Parse(Console.ReadLine());

int[,] array=GetArray(rows,colums,0,20);

PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали = {MainDiagonal(array)}");
//MainDiagonal(array);

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

int MainDiagonal(int[,] array)
{
    int sum=0;
    for(int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {            
            if(i==j)
            {
                sum=sum+array[i,j];
            }
        }
    }
    return sum;
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

/*вариант 2
Console.Clear();
Console.WriteLine ("Введите количество строк ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите количество столбцов ");
int n = int.Parse(Console.ReadLine());
int [,] array = GetDoubleArray(m,n);

PrintArray(GetDoubleArray(m,n));
Console.WriteLine();
Console.WriteLine("Сумма элементов находящихся на главной диагонали = " + SumOfNumbersInIndex(array));

int [,] GetDoubleArray(int m, int n)
{
    int[,] result = new int[m,n];
   
    for (int i =0; i<m; i++)
    {
        for (int j =0; j<n; j++)
        {
            result [i,j] = i+j;
        }
    }
    return result;
}
void PrintArray(int [,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1);j++)
        {
          Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    
}
int SumOfNumbersInIndex (int [,] array)
{
    int sum=0;

    for (int i =0; i<array.GetLength(0); i++)
    {
        for (int j =0; j<array.GetLength(1); j++)
        {
            if (i==j)
            {
                sum = sum +array[i,j];
            }
        }
    }
    return sum;
}
*/