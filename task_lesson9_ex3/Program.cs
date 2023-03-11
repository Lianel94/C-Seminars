// написать прогу, на вход число и возвращать сумму его цифр
// 453 - 12

Console.Clear();

Console.Write("Type the number: ");
int userNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"The sum of the gigits in the number {userNumber} is {GetSum(userNumber)}");

// int sum = 0;
// while(userNumber > 0)
// {
// 	sum += userNumber % 10;
// 	userNumber /= 10;
// }
// Console.WriteLine($"{sum}");

int GetSum(int userNumber)
{
	if (userNumber == 0) return 0;
	return (userNumber % 10 + GetSum(userNumber / 10));
}