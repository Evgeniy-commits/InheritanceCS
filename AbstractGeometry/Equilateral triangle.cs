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
	internal class EquilateralTriangle : IsoscelesTriangle
	{
		//double side;
		//public double Side
		//{
		//	get => side;
		//	set => side = FilterSize(value);
		//}
		public EquilateralTriangle
			(
			double side,
			int startX, int startY, int lineWidth, Color color
			) : base(side, side, startX, startY, lineWidth, color)
		{	}
		//public override double GetHeight() => Math.Sqrt(Math.Pow(Side, 2) - Math.Pow(Side / 2, 2));
		//public override double GetArea() => Side * GetHeight() / 2;
		//public override double GetPerimetr() => Side * 3;
		
		//public override void Draw(System.Windows.Forms.PaintEventArgs e)
		//{
		//	Pen pen = new Pen(Color);
		//	SolidBrush brush = new SolidBrush(Color.Yellow);
		//	Point[] verticesTriangle = new Point[]
		//		{
		//			new Point(StartX, StartY + (int)Side),
		//			new Point(StartX + (int)Side, StartY + (int)Side),
		//			new Point(StartX + (int)Side / 2, StartY + (int)Side - (int)GetHeight())
		//		};
		//	e.Graphics.DrawPolygon(pen, verticesTriangle);
		//	e.Graphics.FillPolygon(brush, verticesTriangle);
		//}
		//public override void Info(System.Windows.Forms.PaintEventArgs e)
		//{
		//	Console.WriteLine();
		//	Console.WriteLine(GetType());
		//	Console.WriteLine($"Длина стороны: {Side}");
		//	base.Info(e);
		//}
	}
}

﻿