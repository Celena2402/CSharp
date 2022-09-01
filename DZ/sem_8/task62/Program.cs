/*
Задача 62: 
   Заполните спирально массив 4 на 4
   Например, на выходе получается вот такой массив:
  01 02 03 04
  12 13 14 05
  11 16 15 06
  10 09 08 07
*/

int[,] SpiralArray(int n)
{
   int[,] array=new int[n,n];
   int temp=1;
   int i=0;
   int j=0;
   while (temp<=array.GetLength(0)*array.GetLength(1))
   {
      array[i,j]=temp;
      temp++;  //temp=temp+1;
      if (i<=j+1 && i+j<array.GetLength(1)-1) 
          j++; // j=j+1
      
      else
      if (i<j && i+j>=array.GetLength(0)-1)
          i++; //i=i+1

      else
      if (i>=j && i+j>array.GetLength(1)-1) 
          j--; //j=j-1

      else 
          i--; //i=i-1
      
   }
return array;
}

void PrintArray(int[,] array)
{
   
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
         if (array[i,j]<10)
         {
            Console.Write($" 0{array[i,j]} ");
         }
         else
         {
            Console.Write($" {array[i,j]} ");
         }         

        }
        Console.WriteLine();
    }
}

Console.Write("Введите размерность квадратной матрицы: n= ");
int n=Convert.ToInt32(Console.ReadLine());
//int n=5;
int[,] array=SpiralArray(n);
//PrintArray(SpiralArray(n));
PrintArray(array);

