// задайте двумерный массив. написать программу, 
// к-я упорядочит по убыванию эл-ты каждой строки двумерного массива


Console.WriteLine("введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("полученный массив: ");
int[,] array2d = new int[m, n];

for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        array2d[i, j] = new Random().Next(1, 10);

        Console.Write(array2d[i, j] + " "); 
          
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1) - 1; j++)
    {
        for (int k = j + 1; k < array2d.GetLength(1); k++)
        {
            if (array2d[i, j] < array2d[i, k])
            {
                
                int temp = array2d[i, j];
                array2d[i, j] = array2d[i, k];
                array2d[i, k] = temp;
            }
        }
    }
}

Console.WriteLine("Упорядоченный массив: ");
for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        Console.Write(array2d[i, j] + " ");
    }
    Console.WriteLine();
}
