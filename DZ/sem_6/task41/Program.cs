/*
Задача 41: 
   Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
   больше 0 ввёл пользователь
   0, 7, 8, -2, -2 -> 2 ; -1, -7, 567, 89, 223-> 3

*/

Console.WriteLine("Сколько чисел будет вводиться? ");
int leng=Convert.ToInt32(Console.ReadLine());

int [] Array=new int[leng];

int i=0;
while (i<leng)
{
    Console.Write($"Введите {i+1} элемент = ");
    Array[i]=int.Parse(Console.ReadLine());
    i++;
}
Console.Write($"Ввели {leng} таких чисел: ");

//вывод содержимого массива
for (i=0; i<leng; i++)
{
    Console.Write($" "+ Array[i]+ " ");
}
Console.WriteLine();

int kol=0;
for (i=0; i<leng; i++)
{
    if (Array[i]>0)
    {
        kol=kol+1;
    }
}
Console.WriteLine($"Количество положительных чисел = {kol}");
