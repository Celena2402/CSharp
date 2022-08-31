/*
Задача 62: 
   Заполните спирально массив 4 на 4
   Например, на выходе получается вот такой массив:
  01 02 03 04
  12 13 14 05
  11 16 15 06
  10 09 08 07
*/
/*
int[,] NewArray(int n)
{
   int[,] array=new int[n,n];
   int temp=1;
   int i=0;
   int j=0;
   while (temp<=array.GetLength(0)*array.GetLength(1))
   {
      array[i,j]=temp;
      temp++;//temp=temp+1;
      if (i<=j+1 && i+j<array.GetLength(1)-1)
      {
         j++; // j=j+1
      }
      else
      {
         if (i<j && j>=array.GetLength(0)-1)
         {
            i++; //i=i+1
         }
      }
      else
      {
         if (i>=j && i=j>array.GetLength(1)-1)
         {
            j--; //j=j-1
         }
      }
      else
      {
         i--; //i=i-1
      }
   }

}

void PrintArray(int[,] array)
{
   
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            Console.Write($"  {array[i,j]} ");

        }
        Console.WriteLine();
    }
}

//Console.Write("Введите размерность квадратной маторицы: n= ");
//int n=Convert.ToInt32(Console.ReadLine());
int n=4;
//int[,] array=new int[n,n];
int[,] array=NewArray(n,n);
PrintArray(array);
*/

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
