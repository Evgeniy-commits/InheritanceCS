//#define ABSTRACT_1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;    ///DLLImport
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
					Console.WindowLeft, Console.WindowTop,
					Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect );
			//e.Graphics.DrawRectangle(new Pen(Color.Red, 5), 300, 200, 500, 200);

#if ABSTRACT_1
			Rectangle rectangle = new Rectangle(100, 40, 500, 50, 3, Color.AliceBlue);
			rectangle.Info(e);
			Square square = new Square(100, 300, 150, 3, Color.Blue);
			rectangle.Info(e);

			//Circle circle = new Circle(100, 500, 200, 3, Color.Yellow);
			//circle.Info(e);

			//IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(50, 100, 500, 200, 3, Color.Brown);
			//isoscelesTriangle.Info(e);

			//EquilateralTriangle equilateral = new EquilateralTriangle(50, 400, 250, 3, Color.Brown);
			//equilateral.Info(e);


			while (true)
			{
				rectangle.Draw(e);
				square.Draw(e);
				//circle.Draw(e);
				//equilateral.Draw(e);
				//isoscelesTriangle.Draw(e);
			} 
#endif

			Shape[] shapes =
			{
				new Rectangle(100, 40, 500, 50, 3, Color.AliceBlue),
				new Square(100, 300, 150, 3, Color.Blue),
				new Circle(100, 500, 200, 3, Color.Yellow),
				new IsoscelesTriangle(50, 100, 500, 200, 3, Color.Brown),
				new EquilateralTriangle(50, 400, 250, 3, Color.Brown)
			};
			for (int i = 0; i < shapes.Length; i++)
			{
				if (!(shapes[i] is IHaveDiagonal)) 
				shapes[i].Draw(e);
			}
		}

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
	}
}
