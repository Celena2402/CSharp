/*
Задача 57: 
Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.

Набор данных Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/
Console.WriteLine("Введите количество строк");
int raws = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите количество столбцов");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[raws, colums];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int[] GetRowArray(int[,] array)
{
    int[] result = new int[array.GetLength(0) * array.GetLength(1)];
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[count] = array[i, j];
            count++;
        }
    }
    return result;
}
void SortArray(int[] result)
{
    for (int i = 0; i < result.Length; i++)
    {
        for (int j = i + 1; j < result.Length; j++)
        {
            if (result[i] > result[j])
            {
                int temp = result[i];
                result[i] = result[j];
                result[j] = temp;
            }
        }
    }
}
void PrintDate(int[] result)
{
    int count = 1;
    int firstNumber = result[0];
    for (int i = 1; i < result.Length; i++)
    {
        if (result[i] != firstNumber)
        {
            Console.WriteLine($"{firstNumber} встречается {count} раз.");
            firstNumber = result[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{firstNumber} встречается {count} раз.");
}


FillArray(array);
PrintArray(array);
int [] result = GetRowArray(array);
Console.WriteLine();
SortArray(result);
PrintDate(result);

