/*
Задача 37: (seminar_1/sem_5/Task37)
     Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
    последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
    [1 2 3 4 5] -> 5 8 3
    [6 7 3 6] -> 36 21

*/
/*
int[] arr = new int[20]; // создали массив из восьми элементов

void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();
        //Получить случайное число 
        int value = rnd.Next(1000);
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}

void GetNewArray(int[] array)
{
    int[] newArr=new int[arr.Length/2];
    int j=arr.Length;

    if (arr.Length % 2==0)
    {
        for (int i=0; i<arr.Length/2; i++)
        {
            newArr[i]=arr[i]*arr[j-i-1];
            Console.WriteLine(newArr[i]);
        }  
    }
else
{
Console.WriteLine("nothing");
}
//Console.WriteLine(newArr);
}

GetNewArray(arr);*/


int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int [size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

Console.WriteLine("Введите количество элементов в массиве:");
int leng=Convert.ToInt32(Console.ReadLine());
int [] array = GetArray(leng, 0, 9);
Console.WriteLine();

int pow = 0;

for(int i = 0; i <= (array.Length-1) / 2; i++)
{
    if(i != array.Length - 1 - i)
    {
    pow = array[i] * array[array.Length - 1 - i];
    }
    else
    {
        pow = array[i];
    }
    Console.Write($"{pow} ");
    
}
Console.WriteLine();

