// Написать программу, которая обменивает элементы первой строки и последней строки

Console.Clear();

int[,] array = GetArray(4, 4, 0, 10);
PrintArray(array);
Console.WriteLine();
array = ExchangeLine(array);
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
			Console.Write($"{inArray[i, j]} ");
		}
		Console.WriteLine();
	}
}

int[,] ExchangeLine(int[,] inArray)
{
	for (int j = 0; j < inArray.GetLength(1); j++)
	{
		int a = inArray[inArray.GetLength(0) - 1, j];
		inArray[inArray.GetLength(0) - 1, j] = inArray[0, j];
		inArray[0, j] = a;
	}
	return inArray;
}