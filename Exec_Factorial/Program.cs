using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int value = 1;
			int numberInt = 7;

			for (int i = 1; i <= numberInt; i++)
			{
				value = value * i;
			}
			Console.WriteLine("階乘" + numberInt + "等於" + value);
		}
	}
}
