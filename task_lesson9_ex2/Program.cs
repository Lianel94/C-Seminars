﻿// задать значени m и n. написать прогу, которая выведет все натуральные числа от m до n
// m = 1, n = 5 - 1 2 3 4 5
// m = 4, n = 8 - 4 5 6 7 8

Console.Clear();

Console.Write("Type M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Type N: ");
int n = int.Parse(Console.ReadLine());

for(int i = m; i <= n; i++)
{
	Console.WriteLine($"{i}");
}

Console.WriteLine();

Console.WriteLine(PrintNumbers(n,m));

string PrintNumbers(int m, int n)
{
	if(m == n)
	{
		Console.WriteLine(n);
		return "n";
	}
	string s = PrintNumbers(m, n - 1) + " " + n.ToString();
	Console.WriteLine(s);
	return s;
}