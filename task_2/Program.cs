Console.Write("Type the first number ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Type the second number ");
int number2 = int.Parse(Console.ReadLine());

if(number1 < number2) 
{
    Console.WriteLine("maximum number is " + number2 + " and minimum number is " + number1);
} 
else 
{
    Console.WriteLine("maximum number is " + number1 + " and minimum number is " + number2);
}
