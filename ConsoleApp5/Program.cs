using System;

namespace lab4
{
	class Program
	{
		static void Main(string[] args)
		{
			//test2();
			test3();
		}

		static void test2()
		{
			int z = 8, j;

			for (j = 1; j <= 8; j++)

				if (z % j == 0)
					Console.WriteLine(j);
		}
		static void test3()
		{

			int z = 100, j, sum;

			for (j = 1; j < z; j++)
			{
				sum = 0;

				for (int i = 1; i <j; i++)
				{
					if (j % i == 0)

						sum = sum + i;

				}

				if (sum==j)
					Console.WriteLine(j);
			}
				
		}

	}
}
