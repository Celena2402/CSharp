/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 2D пространстве. 
 A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21 
*/

int userX1=0, userY1=0;
int userX2=0, userY2=0;

Console.WriteLine("Введите Х1:");
userX1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y1:");
userY1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Х2:");
userX2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y2:");
userY2=Convert.ToInt32(Console.ReadLine());

double result=Math.Sqrt((userX2-userX1)*(userX2-userX1)+(userY2-userY1)*(userY2-userY1));
result= Math.Round(result,2); // округление значения
Console.WriteLine($"Расстояние между точками {userX1}:{userY1} и {userX2}:{userY2} равно {result} ");