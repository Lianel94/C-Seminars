// три числа - может ли быть треугольник с этими сторонами. каждая сторона треугольника меньше суммы двух других сторон
Console.Clear();
Console.Write("Type the first number: ");
int a1 = int.Parse(Console.ReadLine());

Console.Write("Type the second number: ");
int b1 = int.Parse(Console.ReadLine());

Console.Write("Type the third number: ");
int c1 = int.Parse(Console.ReadLine());

// Console.Write("Type the numbers through space: ");
// string[] st = Console.ReadLine().Split(' ');
// int a = int.Parse(st[0]);
// int b = int.Parse(st[1]);
// int c = int.Parse(st[2]);

// void isThereTriangle(int a1, int b1, int c1)
// {
// 	if(a1 + b1 > c1 && a1 + c1 > b1 && b1 + c1 > a1)
// 	{
// 		Console.WriteLine("Yes");
// 	} else Console.WriteLine("No");
// }

// Console.WriteLine($"Do the numbers {a1}, {b1}, {c1} form a tringle?");
// isThereTriangle(a1, b1, c1);

if(isTriangle(a1,b1,c1))
{
	Console.WriteLine("Yes");
} else Console.WriteLine("No");

bool isTriangle(int a, int b, int c)
{
	return (((a+b) > c) && ((a+c) > b) && ((b+c) > a));
}
