// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число стобцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n, 0, 9);
Console.WriteLine("\nЗаданная матрица");
PrintMatrix(matrix);
void FindRowMinSumElements(int[,] matrix)
{
    int minsumRow = int.MaxValue;
    int minRow = 0;
    int sumRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }

        if (sumRow < minsumRow)
        {
            minsumRow = sumRow;
            minRow = i;
        }
        Console.WriteLine($"\nСумма {i + 1} строки = {sumRow}");
    }
    Console.WriteLine($"\nНомер строки с минимальной суммой {minRow + 1}");
    Console.WriteLine($"Сумма строки = {minsumRow}");
    Console.WriteLine("\nЭлементы строки с минимальной суммой:");
    int copy = minRow;
    int[] af = new int[n];
    for (int i = 0; i < m; i++)
    {
        af[i] = matrix[copy, i];
        Console.Write(" " + af[i] + " ");
    }
}
FindRowMinSumElements(matrix);
