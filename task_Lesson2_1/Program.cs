// Write a program, choosing a random number from [10, 99] adn showing the biggest digit of it 78 - max 8
Console.Clear(); // clear the console

int number = new Random().Next(10, 100);
int a1 = number / 10;
int a2 = number % 10;
int max = a1;
if(a2 > max) max = a2;
Console.WriteLine($"Maximum digit of the number {number} is {max}");


// write a program with a random 3-digir number (359) and delete the second digit from it (39)

Console.Write("Type the 3-digit number. Example: 247 ");
int userNum = int.Parse(Console.ReadLine());
int digit1 = userNum / 100; //2
int digit2 = userNum % 10; //7

Console.WriteLine($"Two-digit number of the number {userNum} without the middle digit is {digit1 * 10 + digit2}");
Console.WriteLine($"Two-digit number of the number {userNum} without the middle digit is {digit1}{digit2}");

// Два числа, является ли второе число - кратным, если не кратно, то выводить остаток от деления (54, 5)

Console.Write("Type the first number ");
int userNum1 = int.Parse(Console.ReadLine());
Console.Write("Type the second number ");
int userNum2 = int.Parse(Console.ReadLine());

if(userNum1 % userNum2 == 0) 
{
	Console.WriteLine($"{userNum2} кратно {userNum1}");
}
else 
{
	Console.WriteLine($"{userNum2} не кратно {userNum1} и остаток = {userNum1 % userNum2}");
}

// число и проверяет кратно ли оно 7 и 23 одновременно if(a>b && a<c) && - и; || - или if((a>b || a<c) && (x>b || x<c) || d==5 )
// 14 - no, 46 - no, 161 - yes

Console.Write("Type the number ");
int userNumber = int.Parse(Console.ReadLine());
if (userNumber % 7 == 0 && userNumber % 23 == 0) 
{
	Console.WriteLine($"The number {userNumber} кратно числам 7 и 23 одновременно");
}
else
{
	Console.WriteLine($"The number {userNumber} не кратно 7 и 23 одновременно");
}