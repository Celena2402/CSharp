/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int dayNumber = new int();
Console.WriteLine("Введите номер дня недели");
dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber>=1 && dayNumber<8)
{
    if (dayNumber==6 || dayNumber==7)   //  || -значение ИЛИ, && - значение И
    {
        Console.WriteLine("Это выходной день");
    }
    else
    {
        Console.WriteLine("Это рабочий день");
    }
}
else
{
    Console.WriteLine("введите число от 1 до 7!");
}
