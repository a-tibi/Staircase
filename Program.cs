using System;

namespace Staircase
{
	class Program
	{
		public static void staircase(int n)
		{
			for (int i = 1; i < n + 1; i++)
			{
				Console.WriteLine(new String('#', i).PadLeft(n));
			}
		}

		static void Main(string[] args)
		{
			Console.Write("Enter the number of satirs:");
			int n = Convert.ToInt32(Console.ReadLine().Trim());
			staircase(n);
			Console.ReadKey();
		}
	}
}
