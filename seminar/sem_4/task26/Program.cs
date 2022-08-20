/*
Задача 26:Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.WriteLine("Введите число:");
int num=int.Parse(Console.ReadLine());

int GetColNum(int num)
{
    int i=0;
    while (num>0)
    {
        num=num/10;
        i++;    
    }
    return i;
}
Console.WriteLine($"Количество чисел в введенном числе{num} = {GetColNum(num)}");
