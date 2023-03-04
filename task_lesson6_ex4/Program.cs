// копия заданного массива с помощью поэлементного копирования
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

int[] CopyArray(int[] array)
{
	int[] res = new int[array.Length];
	for(int i = 0; i < array.Length; i++)
	{
		res[i] = array[i];
	}
	return res;
}

Console.Write("Type the size of the array: ");
int size = int.Parse(Console.ReadLine());
int[] array = GetArray(size, 1, 99);
Console.WriteLine($"The copy of [{String.Join(", ", array)}] is [{String.Join(", ", CopyArray(array))}]");
