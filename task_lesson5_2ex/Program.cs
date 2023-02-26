﻿Console.Clear();

int[] GetRandomArray(int size, int minValue, int maxValue)
{
	int [] result = new int[size];
	for(int i = 0; i < size; i++)
	{
		result[i] = new Random().Next(minValue, maxValue + 1);
	}
	return result;
}

int[] array = GetRandomArray(4, -9, 9);
Console.WriteLine(String.Join(", ", array));


