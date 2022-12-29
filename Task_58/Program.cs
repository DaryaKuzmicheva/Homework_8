/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[m, n];

    Console.WriteLine($"Первая матрица");
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i, j] = (int)new Random().Next(0,10);
        Console.Write("{0,10}" , + matrix1 [i, j]);
    }
    Console.WriteLine();
}
 
    Console.WriteLine($"Вторая матрица");
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i, j] = (int)new Random().Next(0,10);
        Console.Write("{0,10}" , + matrix2 [i, j]);
    }
    Console.WriteLine();
}
   
    Console.WriteLine($"Результат умножения");
int[,] matrixresult = new int[m, n];
for (int i = 0; i < matrixresult.GetLength(0); i++)
  {
    for (int j = 0; j < matrixresult.GetLength(1); j++)
    {
      matrixresult[i, j] = 0;
      for (int k = 0; k < matrixresult.GetLength(0); k++)
        matrixresult[i, j] += matrix1[i, k] * matrix2[k, j];
        Console.Write("{0,10}" , + matrixresult [i, j]);
    }
        Console.WriteLine();

  }
