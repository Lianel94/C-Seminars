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