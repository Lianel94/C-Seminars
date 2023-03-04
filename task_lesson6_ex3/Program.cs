// преобразовать число в двоичное из десятичного - 5 - 101
// 5 / 2 = 2 (5 - 4 = 1)
// 2 / 2 = 1 (2 - 2 = 0)
// 1 / 2 = 0 (1 - 0 = 1)
Console.Clear();
Console.Write("Type the number: ");
int number = int.Parse(Console.ReadLine());
string res = DecToNum(number, 2); //16

Console.WriteLine($"{number} -> {res}");

string DecToNum(int decNumber, int otherSystem)
{
	string res = "";
	string nums = "0123456789ABCDEF";
	while (decNumber > 0)
	{
		res = nums[decNumber%otherSystem] + res;
		decNumber /= otherSystem;
	}
	return res;
}