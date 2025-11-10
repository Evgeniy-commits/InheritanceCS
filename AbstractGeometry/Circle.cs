using AbstractGeometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Circle : Shape
	{
		double radius;
		public double Radius
		{
			get => radius;
			set => radius = FilterSize(value);
		}
		public Circle(double radius, int startX, int startY, int lineWidth, Color color)
			: base(startX, startY, lineWidth, color)
		{
			Radius = radius;
		}
		public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
		public override double GetPerimetr() => 2 * Math.PI * Radius;
		public override void Draw(System.Windows.Forms.PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			SolidBrush brush = new SolidBrush(Color.Yellow);
			e.Graphics.DrawEllipse(pen, StartX, StartY, (float)(2 * Radius), (float)(2 * Radius));
			e.Graphics.FillEllipse(brush, StartX, StartY, (float)(2 * Radius), (float)(2 * Radius));
		}
		public override void Info(System.Windows.Forms.PaintEventArgs e)
		{
			Console.WriteLine();
			Console.WriteLine($"{this.GetType()}");
			Console.WriteLine($"Радиус: {Radius}");
			Console.WriteLine($"Диаметр: {2 * Radius}");
			base.Info(e);
		}
	}
}

