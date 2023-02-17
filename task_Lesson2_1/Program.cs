// Write a program, choosing a random number from [10, 99] adn showing the biggest digit of it 78 - max 8
Console.Clear(); // clear the console

int number = new Random().Next(10, 100);
int a1 = number / 10;
int a2 = number % 10;
int max = a1;
if(a2 > max) max = a2;
Console.WriteLine($"Maximum digit of the number {number} is {max}");
