// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого 
//элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
            Console.WriteLine(" Ввели не число. Повторите ввод \n");
        }
    }
    return result;
}
int[,] InitArray(int m, int n)
{
    int[,] matrix = new int[3, 4];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-10, 10);
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
void GetNumberOfPosition(int[,] matrix, int m, int n)
{
    if (
    m <= matrix.GetLength(0)
    && m >= 0
    && n <= matrix.GetLength(1)
    && n >= 0
    )
    {
        Console.WriteLine($"Значение искомого элемента = {matrix[m-1, n-1]}");
    }
    else
    {
        Console.WriteLine($"Такой элемент в массиве отсутствует");
    }
}
int rowNumberOfFinde = GetConsole("Введите номер строки искомого элемента в двумерном массиве: ");
int columnNumberOfFinde = GetConsole("Введите номер столбца искомого элемента в двумерном массиве: ");
int[,] array = InitArray(3, 4);
PrintArray(array);
GetNumberOfPosition (array, rowNumberOfFinde, columnNumberOfFinde);