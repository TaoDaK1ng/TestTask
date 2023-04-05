using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Area.Tests
{
	public class CircleTests
	{
		/// <summary>
		/// Проверка выдачи исключения ArgumentException при отрицательном радиусе
		/// </summary>
		[Fact]
		public void Circle_WithNegativeRadius_ShouldThrowsArgumentException()
		{
			//Act
			Action act = () => new Circle(-2);

			//Assert
			Assert.Throws<ArgumentException>(act);
		}

		/// <summary>
		/// Проверка выдачи исключения ArgumentException при нулевом радиусе
		/// </summary>
		[Fact]
		public void Circle_WithZeroRadius_ShouldThrowsArgumentException()
		{
			//Act
			Action act = () => new Circle(0);

			//Assert
			Assert.Throws<ArgumentException>(act);
		}

		/// <summary>
		/// Проверка расчета площади с определенной точностью
		/// </summary>
		[Fact]
		public void Circle_WithRadius_ShouldReturnArea()
		{
			//Act
			var circle = new Circle(5);

			//Assert
			Assert.Equal(78.53981634, circle.Area, 8);
		}
	}
}
