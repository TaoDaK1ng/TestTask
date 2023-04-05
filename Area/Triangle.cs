using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
	public class Triangle : Shape
	{
		/// <summary>
		/// Вычисляет площадь треугольника
		/// </summary>
		/// <param name="sideALength">Длина стороны А</param>
		/// <param name="sideBLength">Длина стороны B</param>
		/// <param name="sideCLength">Длина стороны C</param>
		public Triangle(double sideALength, double sideBLength, double sideCLength)
			: base(Math.Sqrt((sideALength + sideBLength + sideCLength) / 2 
				* (((sideALength + sideBLength + sideCLength) / 2) - sideALength)
				* (((sideALength + sideBLength + sideCLength) / 2) - sideBLength)
				* (((sideALength + sideBLength + sideCLength) / 2) - sideCLength)))
		{
			if (sideALength <= 0 || sideBLength <= 0 || sideCLength <= 0)
				throw new ArgumentException("Одна из длин сторон не является положительной");
			else if (sideALength + sideBLength < sideCLength || sideBLength + sideCLength < sideALength || sideALength + sideCLength < sideBLength)
				throw new ArgumentException("Предоставленые длины сторон не являются треугольником");

			SideLengths = new double[3] { sideALength, sideBLength, sideCLength };
		}

		/// <summary>
		/// Возвращает массив длин сторон
		/// </summary>
		public double[] SideLengths { get; }

		/// <summary>
		/// Возвращает значение является ли треугольник прямоугольным
		/// </summary>
		/// <returns>Значение является ли треугольник прямоугольным</returns>
		public bool IsRectangular()
		{
			Array.Sort(SideLengths);

			return Math.Pow(SideLengths[2], 2) == (Math.Pow(SideLengths[0], 2) + Math.Pow(SideLengths[1], 2));
		}
	}
}
