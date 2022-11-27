// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int GetConsole(string message)
{
    int result;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Ввели не число или число равное нулю. Повторите ввод \n");
        }
    }
    return result;
}
int[,] InitArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 100);
        }
    }
    return matrix;
}
void PrintArray(int[,] matrix)
{
    const int cellWidth = 5;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],cellWidth} ");
        }
        Console.WriteLine();
    }
}
void GetColumnArithmeticSum(int[,] matrix)
{
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        Console.Write($"Среднее арифметического столбца № {j+1}: {sum / matrix.GetLength(0)}\n");
    }
}
int m = GetConsole("Введите размер массива m:");
int n = GetConsole("Введите размер массива n:");
int[,] array = InitArray(m, n);
PrintArray(array);
Console.WriteLine();
GetColumnArithmeticSum(array);