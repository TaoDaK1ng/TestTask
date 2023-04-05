using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
	public class Circle : Shape
	{
		/// <summary>
		/// Вычисляет площадь круга
		/// </summary>
		/// <param name="radius">Радиус круга</param>
		public Circle(double radius) : base(Math.PI * Math.Pow(radius, 2))
		{
			if (radius <= 0.0)
				throw new ArgumentException("Радиус не является положительным");

			Radius = radius;
		}

		/// <summary>
		/// Возвращает радиус
		/// </summary>
		public double Radius { get; }
	}
}
