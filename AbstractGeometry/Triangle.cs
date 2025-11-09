using AbstractGeometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace AbstractGeometry
{
	abstract class Triangle : Shape
	{
		public abstract double GetHeight();
		public Triangle(int start_x, int start_y, int line_width, Color color)
			: base(start_x, start_y, line_width, color) { }
		public override void Info(System.Windows.Forms.PaintEventArgs e)
		{
			Console.WriteLine($"Высота треугольника: {GetHeight()}");
			base.Info(e);
		}
	}
}
