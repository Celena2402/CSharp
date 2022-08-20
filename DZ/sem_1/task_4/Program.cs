/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int Max(int arg1, int arg2, int arg3)
{
    int max =arg1;
    if(arg2>max) max=arg2;
    if(arg3>max) max=arg3;
    return max;
}

Console.WriteLine("Введите три числа:");
int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
int c=int.Parse(Console.ReadLine());


int max=Max(a,b,c);
Console.WriteLine($"Максимальное число = {max}");