// одномерный массив из 123 чисел, найти кол-во элементов массива значения которых лежат в отрезке 10-99
// [5,18,123,6,2] - 1
// [1.2.3.6.2] - 0
//[10.11.12.13.15] - 5

Console.Clear();
int[] startArray = GetArray(123, 0, 150);
Console.WriteLine($"Количество элементов в отрезке [10;99] = {GetCountElements(startArray, 10, 99)}");

int[] GetArray(int size, int minValue, int maxValue)
{
	int [] res = new int[size];
	for(int i = 0; i < size; i++)
	{
		res[i] = new Random().Next(minValue, maxValue + 1);
	}
	return res;
}

int GetCountElements(int[] array, int leftRange, int rightRange) // l - 10, r - 99
{
	int count = 0;
	foreach(int item in array)
	{
		if(item >= leftRange && item <= rightRange) count++;
	}
	return count;
}

