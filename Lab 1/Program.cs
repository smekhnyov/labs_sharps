using CSH_Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

abstract class Figure
{
	public abstract double calculatePerimeter();
	public abstract double calculateArea();

	public abstract string outputInfo();
}

class Rectangle : Figure
{
	public double Width { get; set; }
	public double Height { get; set; }
	public override double calculatePerimeter() => Width * 2 + Height * 2;
	public override double calculateArea() => Width * Height;
	public override string outputInfo() => "Прямоугольник со сторонами " + Width.ToString() + " и " + Height.ToString();
}

class Square : Figure
{
	public double Side { get; set; }
	public override double calculatePerimeter() => Side * 4;
	public override double calculateArea() => Side * Side;
	public override string outputInfo() => "Квадрат со стороной " + Side.ToString();
}

class Circle : Figure
{
	public double Radius { get; set; }
	public override double calculatePerimeter() => 2 * 3.14 * Radius;
	public override double calculateArea() => 3.14 * Radius * Radius;
	public override string outputInfo() => "Круг с радиусом " + Radius.ToString();
}

class Triangle : Figure
{
	public double SideAB { get; set; }
	public double SideBC { get; set; }
	public double SideCA { get; set; }
	public override double calculatePerimeter() => SideAB + SideBC + SideCA;
	public override double calculateArea() => Math.Sqrt(((SideAB + SideBC + SideCA) / 2) *
		(((SideAB + SideBC + SideCA) / 2) - SideAB) *
		(((SideAB + SideBC + SideCA) / 2) - SideBC) *
		(((SideAB + SideBC + SideCA) / 2) - SideCA));
	public void SetSideAB(double sideAB)
	{
		SideAB = sideAB;
	}
	public void SetSideBC(double sideBC)
	{
		SideBC = sideBC;
	}
	public void SetSideCA(double sideCA)
	{
		SideCA = sideCA;
	}
	public double GetSideAB()
	{
		return SideAB;
	}
	public double GetSideBC()
	{
		return SideBC;
	}
	public double GetSideCA()
	{
		return SideCA;
	}
	public override string outputInfo() => "Треугольник со сторонами " + SideAB.ToString() + ", " + SideBC.ToString() + " и " + SideCA.ToString();
}



namespace CSH_Lab1
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}