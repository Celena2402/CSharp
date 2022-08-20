/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
int userX1=0, userY1=0, userZ1=0;
int userX2=0, userY2=0, userZ2=0;

Console.WriteLine("Введите Х точки А:");
userX1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y точки А:");
userY1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z точки А:");
userZ1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Х точки В:");
userX2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y точки В:");
userY2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z точки В:");
userZ2=Convert.ToInt32(Console.ReadLine());
*/

string tA = "";
Console.WriteLine("Введите координаты точки А(x1, y1, z1) (через пробел):");
tA = Console.ReadLine();
string[] tvA = tA.Split(' ').Where(x=>x !="").ToArray();
int userX1 = int.Parse(tvA[0]);
int userY1 = int.Parse(tvA[1]);
int userZ1 = int.Parse(tvA[2]);

string tB = "";
Console.WriteLine("Введите координаты точки B(x2, y2, z2) (через пробел):");
tB = Console.ReadLine();
string[] tvB = tB.Split(' ').Where(x=>x !="").ToArray();
int userX2 = int.Parse(tvB[0]);
int userY2 = int.Parse(tvB[1]); 
int userZ2 = int.Parse(tvB[2]);

int stepen = 2;
double result=Math.Sqrt((Math.Pow((userX2-userX1), stepen))+(Math.Pow((userY2-userY1), stepen))+(Math.Pow((userZ2-userZ1), stepen)));
result= Math.Round(result,2);
Console.WriteLine($"Расстояние между точками {userX1}:{userY1}:{userZ1} и {userX2}:{userY2}:{userZ2} равно {result} ");


