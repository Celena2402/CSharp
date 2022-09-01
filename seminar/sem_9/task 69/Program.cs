/*
 Задача 69: Напишите программу, которая на вход принимает два 
 числа A и B, и возводит число А в целую степень B 
 с помощью рекурсии.
   A = 3; B = 5 -> 243 (3⁵)
   A = 2; B = 3 -> 8
*/

Console.Write("Введите число A: ");
int a=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int b=Convert.ToInt32(Console.ReadLine());

int Pow(int a, int b)
{
    return b==0 ? 1: Pow(a,b-1)*a;    
}
Console.WriteLine(Pow(a,b));

/*
// Второй вариант
Console.WriteLine("Введите число A:");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B:");
int power = Convert.ToInt32(Console.ReadLine());

int Pow(int userNumber, int power)
{
    if(power == 0) return 1;
    else return Pow(userNumber, power - 1) * userNumber;
}

Console.WriteLine(Pow(userNumber,power));
*/