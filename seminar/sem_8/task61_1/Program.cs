/*
Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

Треугольник Паскаля (арифметический треугольник) — бесконечная таблица биномиальных коэффициентов, 
имеющая треугольную форму. В этом треугольнике на вершине и по бокам стоят единицы. 
Каждое число равно сумме двух расположенных над ним чисел. Строки треугольника симметричны 
относительно вертикальной оси. 
*/


Console.Write("Введите количество строк N=");
int n=Convert.ToInt32(Console.ReadLine());

//Первый способ
for (int i=0; i<n; i++)
{
    for (int j=0; j<=(n-i); j++)
    {         
       Console.Write(" ");
    }
    for (int j=0; j<=i; j++)
    {
        Console.Write("  ");
        Console.Write(Factorial(i)/(Factorial(j)*Factorial(i-j)));
    }
    Console.WriteLine();
}

int Factorial(int n)
{
    int fakt=1;
    for (int i=1; i<=n; i++)
    {
        fakt*=i; //fakt=fack*i
    }
return fakt;
}

/* 
//Второй способ
void PascalTriangle(double[,] triagle)
{
    for (int k=0; k<triagle.GetLength(0);k++)
    {
        triagle[k,0]=1;
    }
    for (int i=1; i<triagle.GetLength(0);i++)
    {
        for (int j=1;j<i+1;j++)
        {
            triagle[i,j]=triagle[i-1,j]+triagle[i-1,j-1];
        }
    }

}

void PTriangle(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int count = 0;
    for (int j = array.GetLength(1) - 1; j >= 0; j--)
    {
      if (array[i, j] != 0)
      {
        array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
        array[i, j] = 0;
        count++;
      }
    }
  }
  array[array.GetLength(0) - 1, 0] = 1;
}

void PrintArray(double[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        if (array[i,j]!=0)
        {
            Console.Write($"{array[i,j]} ");
        }
        else
        {
            Console.Write("  ");
        }
        Console.WriteLine();
    }

}

double[,] triangle=new double[n+1,n*2+1];

PascalTriangle(triangle);

PTriangle(triangle);

Console.WriteLine();
PrintArray(triangle);
*/


