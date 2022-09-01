/*
Задача 64: 
   Задайте значения M и N. Напишите программу, которая выведет все
   натуральные числа в промежутке от M до N. (от большего к меньшему)
   M = 1; N = 5. -> "1, 2, 3, 4, 5"
   M = 4; N = 8. -> "4, 6, 7, 8"
*/

Console.Write("Введите число M= ");
int numberM=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N= ");
int numberN=Convert.ToInt32(Console.ReadLine());

string NumberRec(int numberM, int numberN)
{
    if (numberN>numberM)
    {
        return $" {numberN} " + NumberRec(numberM, numberN-1);
    }
    else
    {
       return $" {numberM} ";        
    }
}
Console.WriteLine(NumberRec(numberM,numberN));
