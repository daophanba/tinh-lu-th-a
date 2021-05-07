using System;

namespace Loop
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("nhap mot so bat ky");
			int n = int.Parse(Console.ReadLine());
			int answer = 1;
			for (int i = 1; i <= n; i++)
			{
				// answer *= i means answer = answer * i;
				answer *= i;
			}
			Console.Write(answer);
		}
	}
}