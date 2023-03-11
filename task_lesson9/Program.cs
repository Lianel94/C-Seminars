// 

Console.Clear();
Console.Write("Type N: ");
int n = int.Parse(Console.ReadLine());
for(int i = 1; i <= n; i++)
{
	Console.WriteLine($"{i}");
}
Console.WriteLine();
Console.WriteLine(PrintNumbers(n));

string PrintNumbers(int n)
{
	if(n == 1)
	{
		Console.WriteLine(1);
		return "1";
	}
	string s = PrintNumbers(n - 1) + " " + n.ToString();
	Console.WriteLine(s);
	return s;
}