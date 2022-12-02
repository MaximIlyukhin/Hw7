// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void SumNumbersInColumns(int[,] inArray)
{
    
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        double summ = 0;
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            summ+=inArray[j,i];
        }
        WriteLine($"sum digits in column №{i+1} = {Math.Round(summ/inArray.GetLength(0),1)}");
    }
}

int message1 = GetintFromConsole("Enter number of rows = ");
int message2 = GetintFromConsole("Enter number of columns = ");
int message3 = GetintFromConsole("Enter Min value = ");
int message4 = GetintFromConsole("Enter Max value = ");
int[,] array = GetArray(message1, message2, message3, message4);
PrintArray(array);
SumNumbersInColumns(array);