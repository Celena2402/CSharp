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


int[,] ProductTwoMatrices (int[,] arrayOne, int[,] arrayTwo)
{
    int[,] arrayThree=new int[arrayOne.GetLength(0)-1, arrayTwo.GetLength(1) - 1];
    for (int i=0; i<arrayOne.GetLength(0);i++)
    {
        for (int j=0; j<arrayTwo.GetLength(1);j++)
        {
            arrayThree[i,j]=arrayOne[i,1]*arrayTwo[1,j]

        }
    }
    
}


Console.Write("Введите количество строк в 1-ом массиве= ");
int l=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в 1-ом в массиве= ");
int m=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество строк должно быть равно количеству столбцов первого массива и равно= {m}");
Console.Write("Введите количество столбцов во 2-ом в массиве= ");
int n=Convert.ToInt32(Console.ReadLine());

int[,] arrayOne=NewArray(l,m,0,10);
int[,] arrayTwo=NewArray(m,n,0,10);
Console.WriteLine("Первый массив:");
PrintArray(arrayOne);
Console.WriteLine("Второй массив:");
PrintArray(arrayTwo);
Console.WriteLine();
//SumMin(array);