/*
Задача 27: (DZ/sem_4/task_27)
    Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    452 -> 11; 82 -> 10; 9012 -> 12

*/

int GetSumNums(int number)
{    
        int sum=0; 
        int num=0;
        while (number>0)
        {
            num=number%10;
            sum=sum+num;
            number=number/10;
        }
    return sum;
}

Console.WriteLine("Введите число:");
int num=int.Parse(Console.ReadLine());

Console.Write($"Сумма чисел у числа {num} равно {GetSumNums(num)}");
Console.WriteLine(" ");