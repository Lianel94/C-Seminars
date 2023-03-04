// 39 перевернуть массив: 12345 - 54321
Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
	int[] result = new int[size];
	for(int i = 0; i < size; i++)
	{
		result[i] = new Random().Next(minValue, maxValue + 1);
	}
	return result;
}

int[] SwitchElements(int[] array)
{
	int[] switchResult = new int[array.Length];
	for(int i = 0; i < array.Length; i++)
	{
		switchResult[i] = array[array.Length - i - 1];
	}
	return switchResult;
}

Console.Write("Type the size of the array: ");
int size = int.Parse(Console.ReadLine());
int[] array = GetArray(size, 1, 99);
Console.WriteLine(String.Join(", ", array));

Console.WriteLine($"Switched elements: {String.Join(", ", SwitchElements(array))}");


