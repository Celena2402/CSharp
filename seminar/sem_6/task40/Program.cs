/*
Задача 40
   Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
   треугольник с сторонами такой длины

   *теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы 
   двух других сторон

*/

int a,b,c;
Console.WriteLine("Введите длину стороны а=");
a=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину стороны b=");
b=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину стороны c=");
c=Convert.ToInt32(Console.ReadLine());

string result;
result=Result(a,b,c);
Console.WriteLine(result);

string Result(int a, int b, int c)
{
    string result=string.Empty;
if (a<(b+c) && b<(a+c) && c<(a+b))
{
    result="Такой треугольник может быть";
}
else
{
    result="Такой треугольник не может быть";

}
return result;
}