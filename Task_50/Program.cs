// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

using static System.Console;
Clear();

int GetintFromConsole(string message)
{
    Write(message);
    return int.Parse(ReadLine()!);
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
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

void FindingRightNumber(int[,] inArray, int N)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] == N)
            {
                WriteLine($"This number {N} is in the {i + 1}th row in the {j + 1}th column");
            }
        }
    }
}


int message1 = GetintFromConsole("Enter number of rows = ");
int message2 = GetintFromConsole("Enter number of columns = ");
int message3 = GetintFromConsole("Enter Min value = ");
int message4 = GetintFromConsole("Enter Max value = ");
int message5 = GetintFromConsole("Enter number you want to find = ");
int[,] array = GetArray(message1, message2, message3, message4);
PrintArray(array);
FindingRightNumber(array, message5);