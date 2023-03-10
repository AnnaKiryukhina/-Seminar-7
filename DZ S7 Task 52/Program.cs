// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк в матрице ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void FindAverage(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        double avr = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matrix[j, i];
            avr = Math.Round(Convert.ToDouble(sum) / Convert.ToDouble(m), 1);
        }

        Console.WriteLine($"Среднее значение столбца № {i + 1} равно {avr}");
    }
}

Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FindAverage(matrix);