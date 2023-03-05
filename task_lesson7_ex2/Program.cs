// задать двумерный массив m и n размеров, каждый элемент в массиве: a[i, j] = i + j. вывести полученный массив на экран
// m =3, n = 4
// 0 1 2 3 - 
// 1 2 3 4
// 2 3 4 5 

Console.Clear();

Console.Write("Type the number of row in the array: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Type the number of columns in the array: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);

int[,] GetArray(int m, int n)
{
	int[,] result = new int[m, n];
	for(int i = 0; i < m; i++)
	{
		for(int j = 0; j < n; j++)
		{
			result[i, j] = i + j;
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
