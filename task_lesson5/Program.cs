// массив из 12 элементов, случайно от -9 до 9, и найти сумму отрицательных и положительных эл-тов
Console.Clear();
int[] GetArray(int size)
{
	int[] result = new int[size];
	for (int i = 0; i < size; i++)
	{
		result[i] = new Random().Next(-9, 9);
	}
	return result;
}

int[] GetSum(int[] array)
{
	int pos = 0;
	int neg = 0;
	for(int i = 0; i < array.Length; i++)
	{
		if(array[i] > 0)
		{
			pos += array[i];
		} else 
		{
			neg += array[i];
		}
	}
	int[] finalArray = {pos,neg};
	return finalArray;
}

int[] array = GetArray(12);
Console.WriteLine($"[ {String.Join(", ", array)} ]"); 
Console.WriteLine($"[ {String.Join(", ", GetSum(array))} ]"); 