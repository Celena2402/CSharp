/*
Задача 43. 
   Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
   уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
   пользователем.

   b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Write("Введите b1= ");
double b1=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите угловой коэффициент первой точки k1= ");
double k1=Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2= ");
double b2=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите угловой коэффициент второй точки k2= ");
double k2=Convert.ToDouble(Console.ReadLine());

/*
double x=(b2-b1) / (k1-k2);
double y=(k1*b2-k2*b1) / (k1-k2);
Console.WriteLine($"Точка пересечения Р будет иметь координаты Р({x};{y})");
*/

void Point (double b1, double b2, double k1, double k2)
{
    double x=(b2-b1) / (k1-k2);
    double y=(k1*b2-k2*b1) / (k1-k2);
    if (k1==k2)
    {
        if (b1!=b2)
        {
            Console.WriteLine("Две прямые параллельны.");
        }
        else
        {
            Console.WriteLine("Две прямые совпадают.");
        }
    }
    else
    {
        Console.WriteLine($"Точка пересечения Р будет иметь координаты Р({x};{y})");
    }
}

Point(b1, b2, k1, k2);
