/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int N=new int ();
int stepen = 3;

Console.Write("Введите число N = ");
N = Convert.ToInt16(Console.ReadLine());
for (int i=1; i<= N; i++)
{
     int square = Convert.ToInt32(Math.Pow(i, stepen)); //Math.Pow(i, stepen) - возведение в тепень
       //int square=i*i*i;
       if (i<N)
       {
        Console.Write($" "+square+",");
       }
       else
       {
        Console.Write(" "+Math.Pow(i, stepen));
       //Console.Write(" "+i*i*i);
       }

}
Console.WriteLine(" ");