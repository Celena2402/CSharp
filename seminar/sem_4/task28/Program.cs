/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

Console.WriteLine("Введите число:");
//int num=int.Parse(Console.ReadLine());//Parse - преобразует одит тип данных в другой
int num=Convert.ToInt32(Console.ReadLine());

int GetProNums(int number)
{
    int pro=1;
    int i=1;
    while(i<=number)
    {
        pro=pro*i;
        Console.Write($" {pro} ");
        i++;
    }
    return pro; //возврат функции
}

Console.WriteLine($"Произведение чисел от 1 до А= {GetProNums(num)}");

/*
Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int factorial(int number)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact *= i;
    }
    return fact;
}

Console.WriteLine($"Факториал {factorial(num)}");
*/