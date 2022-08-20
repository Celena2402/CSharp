/*
Задача 38: (DZ/sem_5/task_38)
    Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
    элементов массива.  [3 7 22 2 78] -> 76

*/

int [] GetArray(int size, int minValue, int maxValue)
{
    int[] res=new int[size];
    for (int i=0; i<size;i++)
    {
        res[i]=new Random().Next(minValue, maxValue+1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

Console.WriteLine("Введите количество элементов в массиве:");
int leng=Convert.ToInt32(Console.ReadLine());

int[] array=GetArray(leng,0,99);
Console.WriteLine();

int numMin=array[0];
int numMax=numMin;
for (int i=1;i<leng;i++)
{
    if (array[i]>numMax)
    {
        numMax=array[i];
    } 
    if (array[i]<numMin)
    {
        numMin=array[i];
    }   
}
int raz=numMax-numMin;
Console.WriteLine($"Max= {numMax}");
Console.WriteLine($"Min= {numMin}");
Console.WriteLine($"Разница между Max и Min = {raz}");