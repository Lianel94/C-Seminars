// задать значени m и n. написать прогу, которая выведет все натуральные числа от m до n
// m = 1, n = 5 - 1 2 3 4 5
// m = 4, n = 8 - 4 5 6 7 8

Console.Clear();

Console.Write("Type M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Type N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(PrintNumbers(m, n));

Console.WriteLine();

Console.WriteLine(PrintNumbers(n,m));

string PrintNumbers(int start, int end)
{
	if(end == start)
	{
		Console.WriteLine(end);
		return start.ToString();
	}
	string s = PrintNumbers(start, end - 1) + " " + end.ToString();
	Console.WriteLine(s);
	return s;
}