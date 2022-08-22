/*
Задача 42:
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

Console.WriteLine("Введите число=");
int userNumber=Convert.ToInt32(Console.ReadLine());

int number=userNumber;
int remains=0;

while(number>0)
{
    remains=number%2;
    Console.Write(remains);
    number=number/2;    
}

/*
DecimalToBinary(int decimalDigit)
{   int result = 0;
    while(decimalDigit%10!=0)
    {
        result = decimalDigit%2;
        decimalDigit = decimalDigit/2;
        Console.Write($"{result} ");
    }
}
*/

/* 
//при помощи рекурсии
Console.WriteLine("Введите число=");
int A=Convert.ToInt32(Console.ReadLine());

int TenToTwo(int number)
{
    if (number==1) return 1;
    if (number==0) return 0;
    return number%2+10*TenToTwo(number/2);

}
Console.WriteLine(TenToTwo(A));

*/

Console.WriteLine();