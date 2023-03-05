// задать двумерный массив и найти сумму элементов на главной диагонали индексы (0,0) (1,1)
//1 4 7 2
// 5 9 2 3
// 8 4 2 4
// the sum is 1+9+2=12

Console.Clear();

Console.Write("Type the number of row in the array: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Type the number of columns in the array: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"The sum of the elements on the main diagonal is {GetSumDiag(array)}");

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

int GetSumDiag(int[,] array)
{
	int length = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
	// if(array.GetLength(0) < array.GetLength(1))
	// {
	// 	length = array.GetLength(0);
	// } else 
	// {
	// 	length = array.GetLength(1);
	// }
	int sum = 0;
	for(int i = 0; i < length; i++)
	{
		sum += array[i, i];
	}
	return sum;
}

