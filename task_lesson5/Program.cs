// массив из 12 элементов, случайно от -9 до 9, и найти сумму отрицательных и положительных эл-тов
Console.Clear();
// int[] GetArray(int size)
// {
// 	int[] result = new int[size];
// 	for (int i = 0; i < size; i++)
// 	{
// 		result[i] = new Random().Next(-9, 9);
// 	}
// 	return result;
// }

// int[] GetSum(int[] array)
// {
// 	int pos = 0;
// 	int neg = 0;
// 	for(int i = 0; i < array.Length; i++)
// 	{
// 		if(array[i] > 0)
// 		{
// 			pos += array[i];
// 		} else 
// 		{
// 			neg += array[i];
// 		}
// 	}
// 	int[] finalArray = {pos,neg};
// 	return finalArray;
// }

// int[] array = GetArray(12);
// Console.WriteLine($"[ {String.Join(", ", array)} ]"); 
// Console.WriteLine($"[ {String.Join(", ", GetSum(array))} ]"); 

//2nd OPTION

//int [] GetRandomArray(int size, int minValue, int maxValue)
// {
// 	int[] result = new int[size];
// 	for(int i = 0; i < sizeof; i++)
// 	{
// 		result[i] = new Random().Next(minValue, maxValue + 1);
// 	}
// }

// int[] array = GetRandomArray(12, -9, 9);
// Console.WriteLine(String.Join(", ", array));

int[] GetArray(int size)
{
	int[] result = new int[size];
	for (int i = 0; i < size; i++)
	{
		result[i] = new Random().Next(-9, 9);
	}
	return result;
}
int[] array = GetArray(12);
Console.WriteLine(String.Join(", ", array));

int[] SumPosNeg(int[] array)
{
	int[] result = new int[2]; // создали сразу массив из двух элементов
	foreach (int el in array)
	{
		result[0] += el > 0 ? el : 0; // если el > 0 то плюсуем к резалту, если нет то ноль
		result[1] += el < 0 ? el : 0;
	}
	return result;
}

Console.WriteLine($"Positive sum = {SumPosNeg(array)[0]}, negative sum = {SumPosNeg(array)[1]}");