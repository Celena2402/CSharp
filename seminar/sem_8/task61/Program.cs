/*
Задача 61: Вывести первые N строк треугольника
Паскаля. Сделать вывод в виде равнобедренного
треугольника
*/

Console.Write("Введите количество строк : ");
int n = int.Parse(Console.ReadLine());
           
int[][] triangle = new int[n][];
// первая строка
triangle[0] = new int[] { 1 };
 
for (int i = 1; i < triangle.Length; i++)
{
    triangle[i] = new int[i + 1];  
        for (int j = 0; j <= i; j++)
        {
            if (j == 0 || j == i)
                 triangle[i][j] = 1;
            else
            {
                triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
             }
        }
}
 
for (int i = 0; i < triangle.Length; i++)
    {
        for (int j = 0; j < triangle[i].Length; j++)
            {
                 Console.Write(" {0,-3} ", triangle[i][j]);
            }
                Console.WriteLine();
    }
 
        //Console.ReadKey();
            