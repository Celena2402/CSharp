/*
 - Задача 48: Задайте двумерный массив размера m на n,  каждый элемент в массиве находится 
 по формуле: Aₙₙ = m+n.  Выведите полученный массив на экран.
 m = 3, n = 4.
 0 1 2 3
 1 2 3 4
 2 3 4 5

*/

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int colums=int.Parse(Console.ReadLine());
int[,] array=GetArray(rows,colums,0,20);
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result=new int[m,n];
    for (int i=0; i<m;i++)
    {
        for (int j=0; j<n; j++)
        {
            result[i,j]=i+j;
        }
    }
    return result;
}
/*
int[,] ChangeArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            if(i%2==0 && j%2==0)
            {
                array[i,j]*=array[i,j]; //умножается само на себч
            }
        }
    }
    return array;
}
*/
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