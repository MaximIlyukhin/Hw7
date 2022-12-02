// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

using static System.Console;
Clear();

int GetintFromConsole(string message)
{
    Write(message);
    return int.Parse(ReadLine()!);
}

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 1);
        }
    }

    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}\t");
        }
        WriteLine();
    }
}

int message1 = GetintFromConsole("Enter number of rows = ");
int message2 = GetintFromConsole("Enter number of columns = ");
int message3 = GetintFromConsole("Enter Min value = ");
int message4 = GetintFromConsole("Enter Max value = ");
double[,] array = GetArray(message1, message2, message3, message4);
PrintArray(array);