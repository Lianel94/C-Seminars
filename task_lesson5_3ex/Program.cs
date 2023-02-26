// массив, есть ли число?
// 4 : [6,7,19,345,3] - no
// 3 : [6,7,19,345,3] - yes
Console.Clear();

Console.Write("Type the elements using space: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);
Console.Write("Type the number: ");
int n = int.Parse(Console.ReadLine());
if (FindElement(baseArray, n))
{
	Console.WriteLine("Yes");
} else
{
	Console.WriteLine("No");
}

int[] GetArrayFromString(string stringArray)
{
	string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
	int[] res = new int[nums.Length];
	
	for(int i = 0; i < nums.Length; i++)
	{
		res[i] = int.Parse(nums[i]);
	}
	return res;
}

bool FindElement(int[] array, int el)
{
	foreach(var item in array) // int item
	{
		if(el == item) return true;
	}
	return false;
}
