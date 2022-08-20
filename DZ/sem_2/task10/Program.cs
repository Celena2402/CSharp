/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трехзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number>99 && Number<1000)
{
    int firstNumber = Number / 100;
    int twoNumber = Number/10-firstNumber * 10;
    Console.WriteLine($"В трехзначном числе {Number} второе число получается {twoNumber}.");
}
else
{
    Console.WriteLine($"Это число не трехзначное. Введите другое число!");
}
