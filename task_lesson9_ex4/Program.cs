// прога, на вход вдва числа и возврат первого в целую стпень второго
// a = 3, b = 5 - 243

Console.Clear();

Console.Write("Type the number: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Type the pow: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"The result of number {m} in the power of {n} is {GetPower(m, n)}");

int GetPower(int number, int rank)
{
	if(rank == 0) return 1;
	return (number * GetPower(number, rank - 1));
}