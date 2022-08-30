/*
 Задача 50: 
 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
 и возвращает значение этого элемента или же указание, что такого элемента нет.
 (на вход именно поступает позиция элемента, можете разбить на две переменные или 
 прописать в одну строку и конвертировать в два числа, комментарии в конце семинара по этой задаче)
 Например, задан массив:
 1 4 7 2
 5 9 2 3
 8 4 2 4
 17 -> такого числа в массиве нет

*/

//Console.Clear();

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
            Console.Write($" {array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void IndexNumber(int indexI, int indexJ, int[,] array) 
{
    int result=0;
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++ )
        {
            if (indexI<array.GetLength(0) && indexJ<array.GetLength(1))
            {
                result=array[indexI,indexJ];
            }
            else
            {
                result=0;
            }
        }        
    }
    if (indexI<array.GetLength(0) && indexJ<array.GetLength(1))
    {
        Console.WriteLine($"Элемент массива который стоит на месте ({indexI};{indexJ}) равен {result}");
    }
    else
    {
        Console.WriteLine("Такого элемента нет и вы возможно ввели не правильное место.");
    }

}

Console.Write("Введите количество строк в массиве= ");
int m=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве= ");
int n=Convert.ToInt32(Console.ReadLine());

int[,] array=NewArray(m,n,0,20);
PrintArray(array);

Console.Write($"Введите номер индекса строки от 0 до {array.GetLength(0)-1} массивa = ");
int indexI=Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите номер индекса столбца от 0 до {array.GetLength(1)-1} массива = ");
int indexJ=Convert.ToInt32(Console.ReadLine());

IndexNumber(indexI,indexJ,array);