/*
Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
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
            Console.Write($"{array[i,j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] SwapArrayRowsForColumns(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
            {
                for (int j=i;j<array.GetLength(1);j++)
                {
                int temp = array[i, j];
                array[i, j]=array[j, i];
                array[j, i] = temp;
                }
            }
    return array;
       
}

if (n!=m)
{
    Console.WriteLine("Невозможно поменять строки на столбцы. Матрица должна быть квадратная");
}
else
{
SwapArrayRowsForColumns(array);
PrintArray(array);
}