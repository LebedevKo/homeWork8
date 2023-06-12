// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("полученный массив: ");
int[,] array2d = new int[m, n];
int minSumRowIndex = 0;
int minSum = int.MaxValue;

if (m != n)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = new Random().Next(1, 10);
            sum += array2d[i, j];

            Console.Write(array2d[i, j] + " ");
        }

        if (sum < minSum)
        {
            minSum = sum;
            minSumRowIndex = i + 1;
        }

        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex}");
}
else
{
    Console.WriteLine("Неверно введены данные");
}

