// Напишите программу, которая заполнит спирально массив 4 на 4.


Console.WriteLine("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("полученный массив: ");
int[,] array2d = new int[n, n];

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


int[,] array = new int[n, n];
int value = 1;
int minRow = 0, maxRow = n - 1, minCol = 0, maxCol = n - 1;

while (value <= n * n)
{
    
    for (int col = minCol; col <= maxCol; col++)
    {
        array[minRow, col] = value;
        value++;
    }
    minRow++;

    
    for (int row = minRow; row <= maxRow; row++)
    {
        array[row, maxCol] = value;
        value++;
    }
    maxCol--;

    
    for (int col = maxCol; col >= minCol; col--)
    {
        array[maxRow, col] = value;
        value++;
    }
    maxRow--;

    
    for (int row = maxRow; row >= minRow; row--)
    {
        array[row, minCol] = value;
        value++;
    }
    minCol++;
}


for (int row = 0; row < n; row++)
{
    for (int col = 0; col < n; col++)
    {
        Console.Write($"{array[row, col]:D2} ");
    }
    Console.WriteLine();
}






