/*
Задача 42:
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/
/*
Console.WriteLine("Введите число=");
int userNumber=Convert.ToInt32(Console.ReadLine());

int number=userNumber;
int remains=0;

while(number>0)
{
    remains=number%2;
    Console.Write(remains);
    number=number/2;    
}
*/
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int number = userNumber;
int i = 0; 
while(number > 0)
{ 
    number = number / 2; //Считаем количество делений на 2 
i++;
} 
number = userNumber; //Возвращаем первоначальное значение 
int[] array = new int [i]; //Задаем массив нужного размера 
for(int j = 0; j < i; j++)
{ array[j] = number % 2; //Заполняем его значениями 
number = number / 2;
} 
int[] ReversArray(int[] inArray)
{ 
    int[] result = new int[inArray.Length]; 
    for(int i = 0; i < inArray.Length; i++) 
    { 
       result[i] = inArray[inArray.Length -1 -i]; 
    } 
return result;
} 
int[] reversArray = ReversArray(array); //Переворачиваем 
Console.Write($"Число {userNumber} в двоичной системе счисления равно ");
for(int j = 0; j < reversArray.Length; j++)
{ 
    Console.Write(reversArray[j]); 
}
/*
DecimalToBinary(int decimalDigit)
{   int result = 0;
    while(decimalDigit%10!=0)
    {
        result = decimalDigit%2;
        decimalDigit = decimalDigit/2;
        Console.Write($"{result} ");
    }
}
*/

/* 
//при помощи рекурсии
Console.WriteLine("Введите число=");
int A=Convert.ToInt32(Console.ReadLine());

int TenToTwo(int number)
{
    if (number==1) return 1;
    if (number==0) return 0;
    return number%2+10*TenToTwo(number/2);

}
Console.WriteLine(TenToTwo(A));

*/
/*
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string c = "";

string TenToTwo(int number, string s)
{
  s = number % 2 + s;
  if (number > 1) s = TenToTwo(number /= 2, s);
  return s;
}
c = TenToTwo(a,c);
Console.Write(c);

*/
Console.WriteLine();