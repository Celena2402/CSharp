/*
Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"

*/

Console.Write("Введите число M= ");
int number1=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N= ");
int number2=Convert.ToInt32(Console.ReadLine());

string NumberRec(int number1, int number2)
{
    if (number2>number1)
    {
        return $"{number1}" + NumberRec(number1+1, number2);
    }
    else
    {
        return $"{number2}";
    }
}
Console.WriteLine(NumberRec(number1,number2));