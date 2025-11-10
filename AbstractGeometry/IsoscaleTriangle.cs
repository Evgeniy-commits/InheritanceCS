using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	internal class IsoscelesTriangle:Triangle
	{
		double @base;
		double side;

		public double Base
		{
			get => @base;
			set => @base = FilterSize(value);
		}
		public double Side
		{
			get => side;
			set => side = FilterSize(value);
		}
		public IsoscelesTriangle
			(
			double @base, double side,
			int startX, int startY, int lineWidth, Color color
			) : base(startX, startY, lineWidth, color)
		{
			Base = @base;
			Side = side;
		}
		public override double GetHeight() => Math.Sqrt(Math.Pow(Side, 2) - Math.Pow(Base / 2, 2));
		public override double GetArea() => Base * GetHeight() / 2;
		public override double GetPerimetr() => 2 * Side + Base;

		public override void Draw(System.Windows.Forms.PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			SolidBrush brush = new SolidBrush(Color.Brown);
			Point[] verticesTriangle = new Point[]
				{
					new Point(StartX, StartY + (int)GetHeight()),
					new Point(StartX + (int)Base, StartY + (int)GetHeight()),
					new Point(StartX + (int)Base / 2, StartY)
				};
			e.Graphics.DrawPolygon(pen, verticesTriangle);
			e.Graphics.FillPolygon(brush, verticesTriangle);
		}
		public override void Info(System.Windows.Forms.PaintEventArgs e)
		{
			Console.WriteLine();
			Console.WriteLine($"{this.GetType()}");
			Console.WriteLine($"Длина стороны: {Side}");
			Console.WriteLine($"Длина основания: {Base}");
			base.Info(e);
		}
	}
}
