// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


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
            Console.WriteLine(" Ввели не число или число равное нулю. Повторите ввод \n");
        }
    }
    return result;
}
double[,] InitArray(int m, int n)
{
    double [,] matrix = new double[m,n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round (rnd.Next(-10, 10) + rnd.NextDouble(), 1);
        }
    }
    return matrix;
}
void PrintArray(double[,] matrix)
{
    const int cellWidth = 5;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], cellWidth} ");
        }
        Console.WriteLine();
    }
}
int m = GetConsole("Введите размер массива m:");
int n = GetConsole("Введите размер массива n:");
double[,] array = InitArray(m, n);
PrintArray(array);