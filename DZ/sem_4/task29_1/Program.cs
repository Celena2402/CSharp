/*
Задача 29: (DZ/sem_4/task_29)
    Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    (на примерах демонстрация выводов 5 и 3 размерных массивов, вам же нужно сделать 8)
    1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] ; 6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("Введите количество элементов в массиве:");
int Leng=Convert.ToInt32(Console.ReadLine());
int[] arr = new int[Leng];

void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();          //Создание объекта для генерации чисел
        int value = rnd.Next(100);          //Получить случайное число
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}
RandomArray(arr);
Console.WriteLine();

/*int [] GetArray(int size, int minValue, int maxValue)
{
    int[] res=new int[size];
    for (int i=0; i<size;i++)
    {
        res[i]=new Random().Next(minValue, maxValue+1);
        Console.Write($"{res[i]} ");
    }
    return res;
}


Console.WriteLine("Введите количество элементов в массиве:");
int Leng=Convert.ToInt32(Console.ReadLine());

int[] array=GetArray(Leng,0,99);
Console.WriteLine();*/