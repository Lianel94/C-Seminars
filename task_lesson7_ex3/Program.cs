// задать двумерный массив, найти элементы у которых оба индекса четные и заменить эти элементы на их квадраты
//1 4 7 2
// 5 9 2 3 
// 8 4 2 4
// 1 2 3 4
// new array
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
// 1 4 3 16

Console.Clear();

Console.Write("Type the number of row in the array: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Type the number of columns in the array: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
GetSquareEvenIndex(array);

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

void GetSquareEvenIndex(int[,] arr)
{
	for(int i = 0; i < arr.GetLength(0); i++)
	{
		for(int j = 0; j < arr.GetLength(1); j++)
		{
			if(i % 2 == 1 && j % 2 == 1)
			{
				arr[i, j] *= arr[i, j]; // Convert.ToInt32(Math.Pow(array[i,j], 2));
			}
			Console.Write($"{arr[i, j]} ");
		}
		Console.WriteLine();
	}
}
