/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number<100)
{
    Console.WriteLine($"У данного числа {number} нет третьей цифры");
}
else
{
    int Result=0, Number=0;
       Number=number;
    while (Number>999)
    {
        Number=Number/10;               
    }
    Result=Number%10;
    Console.WriteLine($"Третья цифра у числа {number} получившееся число {Result}.");
}