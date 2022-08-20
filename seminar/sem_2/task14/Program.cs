/*
14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно 
одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/
/*
int delenie1(int number, int number2)
{
    int result1=number % number2;
    return result1; 
}
int delenie2(int number, int number3)
{
       int result2=number % number3;
       return result2; 
}  

Console.WriteLine("Введите число");
int number=int.Parse(Console.ReadLine());



int number2=7;
int number3=23;
int digit1=delenie1(number, number2);
int digit2=delenie2(number, number3);

if (digit1=0 && digit2=0)
{
    Console.WriteLine($"Кратно");    
}
else
{
    Console.WriteLine($"Не кратно");
} */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int divisionOnSeven = number % 7;
int divisionOnTwentyThree = number % 23;

if(divisionOnSeven == 0 && divisionOnTwentyThree == 0)
{
   Console.WriteLine($"Число {number} делится на 7 и на 23 без остатка"); 
}
else
{
     Console.WriteLine($"Число {number} НЕ делится на 7 и на 23 без остатка"); 
}