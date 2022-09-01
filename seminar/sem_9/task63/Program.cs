/*
Задача 63
   Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
   N = 5 -> "1, 2, 3, 4, 5"
   N = 6 -> "1, 2, 3, 4, 5, 6"

*/

string Number(int a, int b)
{
    if (a<=b)
    {
        return $"{a}" +Number(a+1,b);
    }
    else
    {
        return String.Empty;
    }
}
Console.WriteLine(Number(1,10));