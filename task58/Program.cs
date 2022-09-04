// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введие количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[lines, columns];
int[,] numbers2 = new int[lines, columns];
int[,] numbersMult = new int[lines, columns];

FillArray(numbers);
FillArray(numbers2);
Console.WriteLine("\nМатрица 1");
PrintArray(numbers);
Console.WriteLine("\nМатрица 2");
PrintArray(numbers2);

for (int i = 0; i < numbers.GetLength(0); i++)
    for (int j = 0; j < numbers.GetLength(1); j++)
        numbersMult[i, j] = numbers[i, j] * numbers2[i, j];
Console.WriteLine("\nПроизведение матриц");
PrintArray(numbersMult);

void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rand.Next(0, 100);
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "; ");
        Console.WriteLine();
    }
}