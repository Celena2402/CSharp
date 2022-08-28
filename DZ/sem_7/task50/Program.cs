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

Console.Clear();
Console.Write("Введите количество строк в массиве= ");
int n=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве= ");
int m=Convert.ToInt32(Console.ReadLine());

int[,] array=NewArray(n,m,0,20);
PrintArray(array);

int[,] NewArray(int n, int m, int min, int max)
{
    int[,] array=new int[n,m];
    for (int i=0; i<n;i++)
    {
        for (int j=0;j<m;j++)
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

Console.Write("Введите номер индекса строки в массиве = ");
int indexI=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер индекса столбца массива = ");
int indexJ=Convert.ToInt32(Console.ReadLine());

//int[,] array=
IndexNumber(indexI,indexJ,array);

void IndexNumber(int indexI, int indexJ, int[,] array) {
    if (indexI<array.GetLength(0) && indexJ<array.GetLength(1)){
        Console.WriteLine($"Элемент массива который стоит на месте ({indexI};{indexJ}) равен {array[indexI,indexJ]}");
    }
    else{
        Console.WriteLine("Такого элемента нет и вы возможно ввели не правильное место.");
    }

}
/*
int res=array[indexI,indexJ];

if (indexI>=0 && indexJ>=0 && indexI<array.GetLength(0) && indexJ<array.GetLength(1)) {
        Console.WriteLine($"Элемент массива который стоит на месте ({indexI};{indexJ}) равен {res}");
}
else {
        Console.WriteLine("Такого элемента нет и вы возможно ввели не правильное место.");
    }   
*/
