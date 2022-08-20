/*
Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y). 
*/

/*НАЙТИ ОШИБКУ - НЕ РАБОТАЕТ! */

Voit getCoordinateFromQuoter (int quoter)
{
    if (quoter==1)
    {
        Console.WriteLine($"Возможные координаты X>0 и Y>0");
    }
    else if (quoter==2)
    {
        Console.WriteLine($"Возможные координаты X<0 и Y>0");
    }
    else if (quoter==3)
    {
        Console.WriteLine($"Возможные координаты X<0 и Y<0");
    }
    else if (quoter==4)
    {
        Console.WriteLine($"Возможные координаты X>0 и Y<0");
    }
    else 
    {
        //Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine($"ОШИБКА: Введите номер четверти от 1 до 4!");
    }
}
//int userQuoter=0;

Console.WriteLine("Введите номер четверти:");
int userQuoter=Convert.ToInt32(Console.ReadLine());

//int userQuoter=
getCoordinateFromQuoter(userQuoter);
//Console.WriteLine($"Возможные координаты для четверти {quoter} находятся в {quoter} четверти");