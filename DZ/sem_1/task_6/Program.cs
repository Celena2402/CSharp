/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число:");
int number=int.Parse(Console.ReadLine());

int ost=number % 2; // % остаток от деления
    if (ost==0)
    {
        Console.WriteLine("Число четное");
    }
    else
    {
      Console.WriteLine("Число нечетное");  
    }
