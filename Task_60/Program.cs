Console.WriteLine("Введите высоту трехмерной матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ширину трехмерной матрицы");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите глубину трехмерной матрицы");
int h = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[m,n,h];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = new Random().Next(10,100);
        Console.Write("{0,10}" , + array[i, j, k]);
        }
        
    }
    Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
            }
    }    