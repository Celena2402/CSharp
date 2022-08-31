/*
Задача 60: 
   Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
   которая будет построчно выводить массив, добавляя индексы каждого элемента.
   Массив размером 2 x 2 x 2
   66(0,0,0) 25(0,1,0)
   34(1,0,0) 41(1,1,0)
   27(0,0,1) 90(0,1,1)
   26(1,0,1) 55(1,1,1)
*/

int[,,] NewArray(int x, int y, int z)
{
    int[,,] array3=new int[x,y,z];
    for (int i=0; i<x;i++)
    {
        for (int j=0;j<y;j++)
        {
            for (int k=0; k<z; k++)
            {
               array3[i,j,k]=new Random().Next(10,100);
            }            
        }
    }
    return array3;
}

void PrintArray(int[,,] array3)
{
    for (int i=0;i<array3.GetLength(0);i++)
    {      
       for (int j=0;j<array3.GetLength(1);j++)
        {
           Console.Write(" ");
            for (int k=0; k<array3.GetLength(2);k++)
            {
               Console.Write($"{array3[i,j,k]}({i},{j},{k})   ");
            }
            Console.WriteLine();
        }
      Console.WriteLine(); 
    }
     Console.WriteLine(); 
}

Console.WriteLine("Введите размерность массива X*Y*Z");
Console.Write("Введите x= ");
int x=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y= ");
int y=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z= ");
int z=Convert.ToInt32(Console.ReadLine());


int[,,] array3=NewArray(x,y,z);
Console.WriteLine("Трехмерная матрица с координатами (x;y;z)");
PrintArray(array3);



