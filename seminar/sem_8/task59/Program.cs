/*
Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
*/
int[,] FillArray(int rowNumber, int columnNumber)
{
    int[,] result = new int[rowNumber, columnNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < columnNumber; j++)
        {
            result[i, j] = new Random().Next(1, 20);
            Console.Write($"{result[i, j]} \t");
        }
        Console.WriteLine();
    }
    return result;
}

int[] FindMinimumNumber(int[,] array)
{
    int[] result = new int[2];
    int minimum = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minimum)
            {
                minimum = array[i, j];
                result[0] = i;
                result[1] = j;
            }

        }

    }
    return result;
}

int[,] FillNewArray(int[,] array, int[] minimumCoordinates)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == minimumCoordinates[0]) continue;
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == minimumCoordinates[1]) continue;
                result[k, l] = array[i, j];
                l++;
            }
            k++;
            l=0;
        }

    }
    return result;
}

void PrintArray(int[,] newArray)
{
    for (int i = 0; i <newArray.GetLength(0) ; i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write($"{newArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int rowNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int columnNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine();
int[,] array = FillArray(rowNumber, columnNumber);
int[] minimumCoordinates = FindMinimumNumber(array);
int [,] newArray =  FillNewArray(array, minimumCoordinates);
Console.WriteLine();
PrintArray (newArray);