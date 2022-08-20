/*
Задача 36: (DZ/sem_5/task_36)
    Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих
    на нечётных позициях. [3, 7, 23, 12] -> 19 ; [-4, -6, 89, 6] -> 0
    (Искать по индексам)
*/

Console.WriteLine("Введите количество элементов в массиве:");
int leng=Convert.ToInt32(Console.ReadLine());

int[] arr = new int[leng];
void RandomArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();          //Создание объекта для генерации чисел
        int value = rnd.Next(-99,99);          //Получить случайное число
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}
RandomArray(arr);
Console.WriteLine();
Console.WriteLine($"Числа, стоящие на нечетных позициях");

int sum=0;
for (int i=0; i<leng;i++)
{
    if (i%2>0)
    {
        sum=sum+arr[i];
        Console.Write($" "+arr[i]+" ");
    }   
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел ={sum}");