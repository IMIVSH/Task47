// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

int GetDataFromUser(string message)
{
    PrintInColor(message, ConsoleColor.Blue);
    int result = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    return result;
}

void PrintInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

double[,] Get2DDoubleArray(int colLength, int rowLength, int start, int finish)
{
    double[,] array = new double[colLength,rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = new Random().Next(start, finish+1) + Math.Round(new Random().NextDouble(),1);
        }
    }
    return array;
}

void Print2DArray(double[,] array)
{
    Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
        {
            PrintInColor(j + "\t", ConsoleColor.Green);
        }
        Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        PrintInColor(i + "\t", ConsoleColor.Green);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int m = GetDataFromUser("Введите количество строк: ");
int n = GetDataFromUser("Введите количество столбцов: ");
double[,] array = Get2DDoubleArray(m,n,-10,10);
Print2DArray(array);