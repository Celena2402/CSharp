/*
1.Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого
Например:
а=5 b=25->да
 ->нет
-7 ->нет
->да
*/ 

int NumberA = new int();
Console.WriteLine("Введите число");
NumberA=Convert.ToInt32(Console.ReadLine());
int NumberB = new int();
NumberB=Convert.ToInt32(Console.ReadLine());

int result=(NumberA*NumberA);
if (NumberB==NumberA*NumberA)
{
Console.WriteLine($"Число 2, {NumberB} является квадратом числа 1 {NumberA}");
}
else
{
Console.WriteLine($"Число 2, {NumberB} не является квадратом числа 1 {NumberA}");
}
//Console.WriteLine("Степень числа " + userNumber+ " = "+result);
//Console.WriteLine($"Степень числа {userNumber} = {result}");