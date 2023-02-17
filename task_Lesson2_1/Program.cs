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


