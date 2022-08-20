/*
5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа 
в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"

*/ 

int NumberA = new int();
Console.Write("Введите целое число N = ");
Console.WriteLine(" ");
NumberA=Convert.ToInt32(Console.ReadLine());
int range = new int();
// int range = NumberA < 0 ? NumberA : -NumberA;

NumberA=Math.Abs(NumberA);
range=-NumberA;
for (int i=range;  i <=NumberA; i++)
{
    Console.Write($" "+(i)+" ");
}
Console.WriteLine(" ");


