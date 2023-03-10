// задать двумерный массив, заполненный случайными числами
using System;
using static System.Console;

Console.Clear();

Write("Type the number of row in the array: ");
int rows = int.Parse(ReadLine());

Write("Type the number of columns in the array: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
	int[,] result = new int[m, n];
	for(int i = 0; i < m; i++)
	{
		for(int j = 0; j < n; j++)
		{
			result[i, j] = new Random().Next(minValue, maxValue + 1);
		}
	}
	return result;
}

void PrintArray(int[,] inArray)
{
	for(int i = 0; i < inArray.GetLength(0); i++)
	{
		for(int j = 0; j < inArray.GetLength(1); j++)
		{
			Write($"{inArray[i, j]} ");
		}
		WriteLine();
	}
}
