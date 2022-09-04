// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] TransposeMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }
    return newMatrix;
}

Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
Console.WriteLine("\nПервичная матрица");
PrintMatrix(matrix);
int[,] tmatrix = TransposeMatrix(matrix);
Console.WriteLine("\nПеревернутая матрица");
PrintMatrix(tmatrix);