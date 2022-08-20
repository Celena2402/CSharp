/*
Задача 25: 
    Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
    натуральную степень B. 3, 5 -> 243 (3⁵); 2, 4 -> 16
*/

int GetStepNum (int numberA, int numberB)
{
    int result=1;
    for (int i=1; i<= numberB; i++)
    {
        result = Convert.ToInt32(Math.Pow(numberA, i));                  
    }
    return result;
}

int A =new int ();
int B = new int ();

Console.Write("Введите число A = ");
A = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите число B(степень для числа А) = ");
B = Convert.ToInt16(Console.ReadLine());

Console.Write($"Возведение числа A= {A} в натуральную степень B={B} равно {GetStepNum(A, B)}");
Console.WriteLine(" ");