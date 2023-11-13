using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Введите массив чисел через пробел:");
		string[] input = Console.ReadLine().Split(' ');
		int[] nums = new int[input.Length];
		for (int i = 0; i < nums.Length; i++)
		{
			nums[i] = Convert.ToInt32(input[i]);
		}

		Console.WriteLine("Введите целевое число k:");
		int k = Convert.ToInt32(Console.ReadLine());

		bool result = CheckDuplicates(nums, k);

		if (result)
		{
			Console.WriteLine("В массиве есть два элемента, удовлетворяющих условию.");
		}
		else
		{
			Console.WriteLine("В массиве нет двух элементов, удовлетворяющих условию.");
		}
	}

	public static bool CheckDuplicates(int[] nums, int k)
	{
		Dictionary<int, int> dict = new Dictionary<int, int>();

		for (int i = 0; i < nums.Length; i++)
		{
			if (dict.ContainsKey(nums[i]) && Math.Abs(i - dict[nums[i]]) <= k)
			{
				return true;
			}
			else
			{
				dict[nums[i]] = i;
			}
		}

		return false;
	}
}