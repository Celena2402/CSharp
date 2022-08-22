/*
Задача 44
   Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
   Если N = 5 -> 0 1 1 2 3
   Если N = 3 -> 0 1 1
   Если N = 7 -> 0 1 1 2 3 5 8
*/

/*
int userNum = new int();
Console.WriteLine("Введите первое число: ");
userNum = Convert.ToInt32(Console.ReadLine());

int Fibbonachi(int Num) {

	if (Num == 0) return 0;

	if (Num == 1) return 1;

	return Fibbonachi(Num-1) + Fibbonachi(Num-2);
}

Console.WriteLine(Fibbonachi(userNum));
*/

Console.WriteLine("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());

int[] Fib(int size)
{
    int[] arr=new int[size];
    arr[0]=0;
    arr[1]=1;
    for (int i=2; i<size;i++)
    {
        arr[i]=arr[i-1]+arr[i-2];
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        if (i==0) Console.Write("[");
        if (i<arr.Length-1) Console.Write(arr[i]+", ");
        else Console.Write(arr[i]+ "]");
    }
}

int[] Array=Fib(num);
PrintArray(Array);
Console.WriteLine();