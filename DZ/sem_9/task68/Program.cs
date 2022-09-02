/*
Задача 68: 
   Напишите программу вычисления функции Аккермана с помощью
   рекурсии. Даны два неотрицательных числа m и n.
   m = 2, n = 3 -> A(m,n) = 29

   Функция Аккермана — простой пример вычислимой функции, которая не является 
   примитивно рекурсивной. Она принимает два неотрицательных целых числа в качестве 
   параметров и возвращает натуральное число, обозначается А(m,n)
*/

Console.Write("Введите число (m >= 0) = ");
int numberM=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число (n >= 0) = ");
int numberN=Convert.ToInt32(Console.ReadLine());

int AckermanFunction(int numberM, int numberN)
{
  if (numberM == 0)
    return numberN + 1;
  else
    if ((numberM != 0) && (numberN == 0))
      return AckermanFunction(numberM - 1, 1);
    else
      return AckermanFunction(numberM - 1, AckermanFunction(numberM, numberN - 1));
}
Console.WriteLine($"Значение функции Аккермана для двух неотрицательных целых чисел A({numberM},{numberN}) = {AckermanFunction(numberM, numberN)}");