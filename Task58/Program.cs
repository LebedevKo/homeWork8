// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Console.WriteLine("введите число строк для первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов для первой матрицы:: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("первая матрица: ");
int[,] matrix1 = new int[m, n];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i, j] = new Random().Next(1, 10);

        Console.Write(matrix1[i, j] + " "); 
          
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("введите число строк для второй матрицы: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов для второй матрицы:: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("вторая матрица: ");
int[,] matrix2 = new int[k, l];

for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i, j] = new Random().Next(1, 10);

        Console.Write(matrix2[i, j] + " "); 
          
    }
    Console.WriteLine();
}
Console.WriteLine();

if ( n != k)
{
    Console.WriteLine("матрицы нельзя перемножить");
}
else
{
int rows = matrix1.GetLength(0);
int cols = matrix2.GetLength(1);
int[,] resultMatrix = new int[rows, cols];


for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        int sum = 0;
        for (int a = 0; a < matrix1.GetLength(1); a++)
        {
            sum += matrix1[i, a] * matrix2[a, j];
        }
        resultMatrix[i, j] = sum;
    }
}


Console.WriteLine("Результирующая матрица:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(resultMatrix[i, j] + " ");
    }
    Console.WriteLine();
}
}