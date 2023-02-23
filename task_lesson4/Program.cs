// на вход - число а, и выдает сумму чисел от 1 до а
// a = 5, sum = 1+2+3+4+5

int GetSum(int n)
{
	int sum = 0;
	for (int i = 1; i <= n; i++)
	{
		sum += i;
	}
	return sum;
}

Console.Clear();
Console.Write("Type your number: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"The sum from 1 to {n} is {GetSum(n)}");

// число, и сколько цифр в числе: 654 - 3, 84126 - 5

int GetDigitNumber(int userNum)
{
	int i = 0;

	if (userNum < 0)
	{
		userNum *= (-1);
	}

	while (userNum > 0)
	{
		userNum /= 10;
		i++;
	}
	return i;
}

Console.Write("Type your number: ");
int userNum = int.Parse(Console.ReadLine());
Console.WriteLine($"The number of digits in the {userNum} is {GetDigitNumber(userNum)}");

// на вход число и выдает произведение от 1 до числа
//5 - 1*2*3*4*5

int Multiply(int num)
{
	int result = 1;
	for (int i = 1; i <= n; i++)
	{
		result *= i;
	}
	return result;
}

Console.Write("Type your number: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"The sum from 1 to {n} is {Multiply(num)}");