/*
11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int randomNumber = new Random().Next(100, 1000);
int firstNumber = randomNumber / 100;
int thirdNumber = randomNumber % 10;
int number = firstNumber * 10 + thirdNumber;

Console.WriteLine($"Сгенерированное число {randomNumber}. Получившееся число {number}.");

/* НЕ ПРАВИЛЬНО
int GetMaxDeletefromNumber(int number3)
{
    int resalt=number3/100;
    int resalt1=number3 % 10;
    int resalt2=number3*10 + resalt1;

    return resalt2;
}
int number3=new Random().Next(100,999);
int maxDigit=GetMaxDeletefromNumber(number3);
Console.WriteLine($"Из числа {number3} получили {maxDigit}");
*/