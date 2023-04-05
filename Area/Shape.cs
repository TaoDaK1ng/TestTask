using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
	public abstract class Shape
	{
		protected Shape(double area) => Area = area;

		/// <summary>
		/// Возвращает площадь
		/// </summary>
		public double Area { get; }
	}
}