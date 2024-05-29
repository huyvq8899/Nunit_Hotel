using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelUnitTest.TutorialUnitTest
{
	[TestFixture]
	public class MathOperationsTests
	{
		private MathOperations _mathOperations;

		[SetUp]
		public void SetUp()
		{
			_mathOperations = new MathOperations();
		}

		// Add method tests
		[TestCase(2, 3, 5)]
		[TestCase(-2, -3, -5)]
		[TestCase(-2, 3, 1)]
		[TestCase(2, -3, -1)]
		[TestCase(0, 0, 0)]
		[TestCase(0, 5, 5)]
		[TestCase(5, 0, 5)]
		[TestCase(int.MaxValue, 0, int.MaxValue)]
		[TestCase(int.MaxValue, 1, int.MaxValue)]
		[TestCase(int.MinValue, 0, int.MinValue)]
		public void Add_TestCases(int a, int b, int expected)
		{
			int result = _mathOperations.Add(a, b);
			Assert.That(result, Is.EqualTo(expected));
		}

		// Subtract method tests
		[TestCase(5, 3, 2)]
		[TestCase(-5, -3, -2)]
		[TestCase(-5, 3, -8)]
		[TestCase(5, -3, 8)]
		[TestCase(0, 0, 0)]
		[TestCase(0, 5, -5)]
		[TestCase(5, 0, 5)]
		[TestCase(int.MaxValue, 0, int.MaxValue)]
		[TestCase(int.MaxValue, 1, int.MaxValue - 1)]
		[TestCase(int.MinValue, 0, int.MinValue)]
		public void Subtract_TestCases(int a, int b, int expected)
		{
			int result = _mathOperations.Subtract(a, b);
			Assert.That(result, Is.EqualTo(expected));
		}

		// Multiply method tests
		[TestCase(2, 3, 6)]
		[TestCase(-2, -3, 6)]
		[TestCase(-2, 3, -6)]
		[TestCase(2, -3, -6)]
		[TestCase(0, 0, 0)]
		[TestCase(0, 5, 0)]
		[TestCase(5, 0, 0)]
		[TestCase(int.MaxValue, 1, int.MaxValue)]
		[TestCase(int.MinValue, 1, int.MinValue)]
		[TestCase(1, 1, 1)]
		public void Multiply_TestCases(int a, int b, int expected)
		{
			int result = _mathOperations.Multiply(a, b);
			Assert.That(result, Is.EqualTo(expected));
		}

		// Divide method tests
		[TestCase(6, 3, 2.0)]
		[TestCase(-6, -3, 2.0)]
		[TestCase(-6, 3, -2.0)]
		[TestCase(6, -3, -2.0)]
		[TestCase(0, 1, 0.0)]
		[TestCase(0, -1, 0.0)]
		[TestCase(int.MaxValue, 1, (double)int.MaxValue)]
		[TestCase(int.MinValue, 1, (double)int.MinValue)]
		[TestCase(1, 1, 1.0)]
		[TestCase(1, -1, -1.0)]
		public void Divide_TestCases(int a, int b, double expected)
		{
			double result = _mathOperations.Divide(a, b);
			Assert.That(result, Is.EqualTo(expected));
		}

		[Test]
		public void Divide_ByZero_ThrowsDivideByZeroException()
		{
			Assert.Throws<DivideByZeroException>(() => _mathOperations.Divide(6, 0));
		}
	}

}
