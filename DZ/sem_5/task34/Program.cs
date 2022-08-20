/*
Задача 34: (DZ/sem_5/task_34)
    Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
    программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

*/

Console.WriteLine("Введите количество элементов в массиве:");
int leng=Convert.ToInt32(Console.ReadLine());

int[] arr = new int[leng];
void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();          //Создание объекта для генерации чисел
        int value = rnd.Next(100,1000);          //Получить случайное число
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}
RandomArray(arr);
Console.WriteLine();

int kol=0;
for (int i=0; i<leng;i++)
{
    if (arr[i]!%2==0)
    {
        kol=kol+1;       
    }    
}

if (kol>0)
{
    Console.WriteLine($"Количество четных чисел в массиве= {kol}");
}
else
{
    Console.WriteLine($"В массиве нет четных чисел");
}