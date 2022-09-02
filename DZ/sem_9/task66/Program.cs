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

if (numberN % 2 !=0)
{
    numberN=numberN-1;
}

int sum(int numberM, int numberN)
{    
    if (numberM<=numberN)
    {
        return numberN + sum(numberM,numberN-2);
    }
    else
    {
        return 0;
    }
}
Console.WriteLine($"Сумма четных чисел в промежутке от М={numberM} до N={numberN} равна {sum(numberM,numberN)} ");
//Console.WriteLine(sum(numberM,numberN));


