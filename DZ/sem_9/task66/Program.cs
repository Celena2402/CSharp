/*
Задача 66: 
   Задайте значения M и N. Напишите программу, которая найдёт сумму
   натуральных элементов в промежутке от M до N.(сумма четных чисел из промежутка)
   M = 1; N = 15 -> 120
   M = 4; N = 8. -> 30
*/

Console.Write("Введите число M= ");
int numberM=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N= ");
int numberN=Convert.ToInt32(Console.ReadLine());

string NumberRec(int numberM, int numberN)
{
    if (numberN>numberM)
    {
        return $" {numberM} " + NumberRec(numberM+1, numberN);
    }
    else
    {
        return $"{numberN}";
    }
}
Console.WriteLine(NumberRec(numberM,numberN));

/*
int Sum(int n)
{
    if(n==0) return 0;
    else return n%10+Sum(n/10);
}
Console.WriteLine(Sum(n));
*/