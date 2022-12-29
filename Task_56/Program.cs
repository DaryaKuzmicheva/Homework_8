/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = (int)new Random().Next(-100,100);
        Console.Write("{0,10}" , + array[i, j]);
    }
    Console.WriteLine();
}

    int minline = 0;
    int minsum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
        minsum = minsum + array[0,i];
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
        int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
            sum = sum + array[i,j];
            }
        
            if (minsum > sum)
            {
            minsum = sum;
            minline = i;
            }
        Console.WriteLine($"Сумма элементов {i + 1} строки  = {(float)sum}");
        }
              
Console.WriteLine($"Сумма элементов минимальна на строке {minline + 1}");
