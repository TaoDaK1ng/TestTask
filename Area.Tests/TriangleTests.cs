using Xunit;

namespace Area.Tests
{
	public class TriangleTests
	{
		/// <summary>
		/// Проверка выдачи исключения ArgumentException при нулевой стороне
		/// </summary>
		[Fact]
		public void Triangle_WithZeroSide_ShouldThrowsArgumentException()
		{
			//Act
			Action act = () => new Triangle(0, 1, 2);

			//Assert
			Assert.Throws<ArgumentException>(act);
		}

		/// <summary>
		/// Проверка выдачи исключения ArgumentException при отрицательной стороне
		/// </summary>
		[Fact]
		public void Triangle_WithNegativeSide_ShouldThrowsArgumentException()
		{
			//Act
			Action act = () => new Triangle(1, -2, 3);

			//Assert
			Assert.Throws<ArgumentException>(act);
		}

		/// <summary>
		/// Проверка выдачи исключения ArgumentException при несуществующем треугольнике
		/// </summary>
		[Fact]
		public void Triangle_WithSideMoreThanSumTwoSides_ShouldThrowsArgumentException()
		{
			//Act
			Action act = () => new Triangle(10, 1, 2);

			//Assert
			Assert.Throws<ArgumentException>(act);
		}

		/// <summary>
		/// Проверка расчета площади с определенной точностью
		/// </summary>
		[Fact]
		public void Triangle_WithSides_ShouldReturnArea()
		{
			//Act
			var triangle = new Triangle(40, 35, 25);

			//Assert
			Assert.Equal(433.0127018922, triangle.Area, 10);
		}

		/// <summary>
		/// Проверка расчета прямоугольности прямоугольного треугольника
		/// </summary>
		[Fact]
		public void IsRectangular_WithSidesForRightTriangle_ShouldReturnTrue()
		{
			//Arrange
			var triangle = new Triangle(17, 144, 145);

			//Act
			var isRectangular = triangle.IsRectangular();

			//Assert
			Assert.True(isRectangular);
		}

		/// <summary>
		/// Проверка расчета прямоугольности не прямоугольного треугольника
		/// </summary>
		[Fact]
		public void IsRectangular_WithSidesForNotRightTriangle_ShouldReturnFalse()
		{
			//Arrange
			var triangle = new Triangle(17, 144, 145.04);

			//Act
			var isRectangular = triangle.IsRectangular();

			//Assert
			Assert.False(isRectangular);
		}
	}
}
