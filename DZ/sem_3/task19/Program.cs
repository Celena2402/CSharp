/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите число не меньше пятизначного: ");
int Number = Convert.ToInt32(Console.ReadLine());

int num=Number;
int obr=0;

if (Number>9999)
{
    while (Number>0)
    {
        int pramo=Number%10;
        obr=obr*10+pramo;
        Number=Number/10;
        //Console.WriteLine($"Прямое значение {num}");
    }
    if (num==obr)
    {
        Console.WriteLine("Это палиндром!");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом!");
    }

}
else
{
    Console.WriteLine($"Это число меньше пятизначного. Введите другое число!");
}
