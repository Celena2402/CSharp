/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

*/
//int a1=-115;
//int b1=-211;
Console.WriteLine("Введите первое число -");
int a1=int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число -");
int b1=int.Parse(Console.ReadLine());

int max =a1;
if (b1>max) max=b1;
Console.WriteLine($"Максимальное число = {max}"); 

int min =a1;
if (b1<min) 
{
    min=b1;    
}
Console.WriteLine($"Минимальное число = {min}"); 