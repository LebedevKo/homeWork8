// задайте двумерный массив. написать програпмму, к-я поменяет местами первую и последнюю строчки
/*
Console.WriteLine("введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
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

int temp;
for (int j = 0; j < array2d.GetLength(1); j++)
{
    temp = array2d[0, j]; 
    array2d[0, j] = array2d[array2d.GetLength(0) - 1, j]; 
    array2d[array2d.GetLength(0) - 1, j] = temp; 
}
Console.WriteLine("Массив после обмена первой и последней строки:");

for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        Console.Write(array2d[i, j] + " ");
    }
    Console.WriteLine();
}
*/

// задайте двумерный массив. написать прогу, к-я заменяет строки на столбцы. 
// в случае, если это не возможно, программа должна вывести сообщения для пользователя

/*

Console.WriteLine("введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
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

if (array2d.GetLength(0) != array2d.GetLength(1))
{
    Console.WriteLine("Замена строк на столбцы невозможна. Число строк и столбцов должно быть одинаковым.");
}
else
{
    
    int[,] temp = new int[array2d.GetLength(1), array2d.GetLength(0)];

    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            temp[j, i] = array2d[i, j];
        }
    }

    Console.WriteLine("Массив после замены строк на столбцы:");
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        for (int j = 0; j < temp.GetLength(1); j++)
        {
            Console.Write(temp[i, j] + " ");
        }
        Console.WriteLine();
    }
}

*/


//  составить частотый словарь эл-тов двумерного массива. 
// Частотный словарь содержит инфу о том, сколько раз встречается элемент входных данных.

Console.WriteLine("введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
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

int[] arrayTemp = new int[m*n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        int index = i * n + j;
        arrayTemp[index] = array2d[i, j];
    }
}

// for (int i = 0; i < m*n; i++)
// {
//     Console.Write(arrayTemp[i] + " ");
// }
//Console.WriteLine();


for (int i = 0; i < arrayTemp.Length - 1; i++)
{
    for (int j = 0; j < arrayTemp.Length - 1 - i; j++)
    {
        if (arrayTemp[j] > arrayTemp[j + 1])
        {
            
            int temp = arrayTemp[j];
            arrayTemp[j] = arrayTemp[j + 1];
            arrayTemp[j + 1] = temp;
        }
    }
}

// for (int i = 0; i < arrayTemp.Length; i++)
// {
//     Console.Write(arrayTemp[i] + " ");
// }
//Console.WriteLine();

int count = 0;
int element = arrayTemp[0];
foreach (int i in arrayTemp)
{
    if (i == element)
    {
    count++;
    }
    else
    {
        
        Console.WriteLine($"число {element} встретился {count} раз ");
        element = i;
        count = 1;
    }
}
Console.WriteLine($"число {element} встретился {count} раз ");
Console.WriteLine();






