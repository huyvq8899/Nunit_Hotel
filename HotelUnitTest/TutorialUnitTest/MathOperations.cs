using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelUnitTest.TutorialUnitTest
{
	public class MathOperations
	{
		public int Add(int a, int b)
		{
			return a + b;
		}

		public int Subtract(int a, int b)
		{
			return a - b;
		}

		public int Multiply(int a, int b)
		{
			return a * b;
		}

		public double Divide(int a, int b)
		{
			if (b == 0)
				throw new DivideByZeroException("Cannot divide by zero");
			return (double)a / b;
		}
	}
}
