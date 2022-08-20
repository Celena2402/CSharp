/*
Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу квадратов чисел от 1 до N. 5 -> 1, 4, 9, 16, 25. 2 -> 1,4
*/
int N=new int ();
Console.Write("Введите число N = ");
N = Convert.ToInt16(Console.ReadLine());
//Console.Write(1);
for (int i=1; i<= N; i++)
{
       int square=i*i;
       if (i<N)
       {
        Console.Write($" "+square+",");
       }
       else
       {
        Console.Write(" "+i*i);
       }

  //  Console.Write($" "+square+",");    

}
Console.WriteLine(" ");