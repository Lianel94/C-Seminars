// Координаты точки по х, y и в какой четверти, например (2;2) - 1 четверть

Console.Clear();
Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
	Console.WriteLine("1");
}
else if (x < 0 && y > 0)
{
	Console.WriteLine("2");
}
else if (x < 0 && y < 0)
{
	Console.WriteLine("3");
}
else if (x > 0 && y < 0)
{
	Console.WriteLine("4");
}
else if (x == 0 || y == 0)
{
	Console.WriteLine("На оси");
}

// по заданной четверти, диапозон возможных координат x и y (x>0;y<0)
Console.Write("Type the quarter from 1 to 4: ");
int quarter = int.Parse(Console.ReadLine());

// if(quarter == 1)
// {
// 	Console.WriteLine("x > 0 and y > 0");
// } else if(quarter == 2)
// {
// 	Console.WriteLine("x < 0 and y > 0");
// } else if(quarter == 3)
// {
// 	Console.WriteLine("x < 0 and y < 0");
// } else if(quarter == 4)
// {
// 	Console.WriteLine("x > 0 and y < 0");
// }

switch (quarter)
{
	case 1:
		{
			Console.WriteLine("x > 0 and y > 0");
			break;
		}
	case 2:
		{
			Console.WriteLine("x < 0 and y > 0");
			break;
		}
	case 3:
		{
			Console.WriteLine("x < 0 and y < 0");
			break;
		}
	case 4:
		{
			Console.WriteLine("x > 0 and y < 0");
			break;
		}
	default:
		{
			Console.WriteLine("Введена неправильная четверть");
			break;
		}
}

// на вход - координаты двух точек и находит расстояние между ними в два д пространстве.
// a (3, 6), b (2 1)
// sqrt((3-2)^2 + (6-1)^2)
// double s = Math.Sqrt(...);

Console.Write("Введите координаты 1 числа по x: ");
int x1 = int.Parse(Console.ReadLine()); // double xi = double.Parse(Console.ReadLine());
Console.Write("Введите координаты 1 числа по y: ");
int y1 = int.Parse(Console.ReadLine()); // double xi = double.Parse(Console.ReadLine());

Console.Write("Введите координаты 2 числа по x: ");
int x2 = int.Parse(Console.ReadLine()); // double xi = double.Parse(Console.ReadLine());
Console.Write("Введите координаты 2 числа по y: ");
int y2 = int.Parse(Console.ReadLine()); // double xi = double.Parse(Console.ReadLine());

Console.WriteLine($"Расстояние между двумя точками с координатами {x1}-{y1} и {x2}-{y2} равно {Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 2)}");
// если через double - math.round - no need

//число на вход, и выводит таблицу квадрат от 1 до числа
// 5 - 1 4 9 16 25

Console.Write("Введите число: ");
int userNum = int.Parse(Console.ReadLine());
// int ind = 1;

// while(ind <= userNum)
// {
// 	Console.WriteLine(Math.Pow(ind, 2));
// 	ind++;
// }

int[] result = new int[userNum];
for(int i = 1; i <= userNum; i++)
{
	result[i - 1] = i * i;
}
for (int i = 0; i < userNum; i++)
{
	Console.Write($"{result[i]} ");
}

// Console.Clear();
// Console.Write("Write the number N: ");
// int N = int.Parse(Console.ReadLine());
// int i = 1;
// int m = N;

// if (N < 0)
// {
// 	i = N;
// 	m = -N;
// 	N = -1;
// }

// int[] Result = new int[m];
// int j = 0;
// for(; i <= N; i++)
// {
// 	Result[j] = i * i;
// 	j++;
// }
// for (j = 0; j < m; j++)
// {
// 	Console.Write($"{Result[j]} ");
// }