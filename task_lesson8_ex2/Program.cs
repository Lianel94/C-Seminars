// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

Console.Clear();

Console.Write("Type the number of row in the array: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Type the number of columns in the array: ");
int columns = int.Parse(Console.ReadLine());

if (rows == columns)
{
    int[,] array = GetArray(rows, columns, 0, 10);
    PrintArray(array);
    Console.WriteLine();
    array = ExchangeArray(array);
    PrintArray(array);
} else Console.WriteLine("Impossible!");


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ExchangeArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = i + 1; j < inArray.GetLength(1); j++)
        {
            int a = inArray[i, j];
            inArray[i, j] = inArray[j, i];
            inArray[j, i] = a;
        }
    }
    return inArray;
}