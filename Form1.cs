namespace CSH_Lab1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Graphics g;

		private void button_square_Click(object sender, EventArgs e)
		{
			groupBox_square.Visible = true;
			groupBox_circle.Visible = false;
			groupBox_triangle.Visible = false;
			groupBox_rectangle.Visible = false;
		}

		private void button_circle_Click(object sender, EventArgs e)
		{
			groupBox_square.Visible = false;
			groupBox_circle.Visible = true;
			groupBox_triangle.Visible = false;
			groupBox_rectangle.Visible = false;
		}

		private void button_triangle_Click(object sender, EventArgs e)
		{
			groupBox_square.Visible = false;
			groupBox_circle.Visible = false;
			groupBox_triangle.Visible = true;
			groupBox_rectangle.Visible = false;
		}

		private void button_rectangle_Click(object sender, EventArgs e)
		{
			groupBox_square.Visible = false;
			groupBox_circle.Visible = false;
			groupBox_triangle.Visible = false;
			groupBox_rectangle.Visible = true;
		}

		private void button_ok_Click(object sender, EventArgs e)
		{
			g = CreateGraphics();
			g.Clear(Color.FromArgb(240, 240, 240));
			bool is_empty = false;
			if (groupBox_rectangle.Visible)
			{
				if (textBox_rect_A.Text == "" || textBox_rect_B.Text == "")
				{
					is_empty = true;
				}
				else
				{
					var shape = new Rectangle { Width = double.Parse(textBox_rect_A.Text), Height = double.Parse(textBox_rect_B.Text) };
					label_perimeter.Text = "Периметр: " + Convert.ToString(shape.calculatePerimeter());
					label_square.Text = "Площадь: " + Convert.ToString(shape.calculateArea());
					g.DrawRectangle(Pens.Black, 500, 150, ((float)shape.Width), ((float)shape.Height));
				}
			}
			if (groupBox_square.Visible)
			{
				if (textBox_square.Text == "")
				{
					is_empty = true;
				}
				else
				{
					var shape = new Square { Side = double.Parse(textBox_square.Text) };
					label_perimeter.Text = "Периметр: " + Convert.ToString(shape.calculatePerimeter());
					label_square.Text = "Площадь: " + Convert.ToString(shape.calculateArea());
					g.DrawRectangle(Pens.Black, 500, 150, ((float)shape.Side), ((float)shape.Side));
				}
			}
			if (groupBox_circle.Visible)
			{
				if (textBox_circle.Text == "")
				{
					is_empty = true;
				}
				else
				{
					var shape = new Circle { Radius = double.Parse(textBox_circle.Text) };
					label_perimeter.Text = "Периметр: " + Convert.ToString(shape.calculatePerimeter());
					label_square.Text = "Площадь: " + Convert.ToString(shape.calculateArea());
					g.DrawEllipse(Pens.Black, 500, 150, ((float)shape.Radius), ((float)shape.Radius));
				}
			}
			if (groupBox_triangle.Visible)
			{
				if (textBox_tri_A.Text == "" || textBox_tri_B.Text == "" || textBox_tri_C.Text == "")
				{
					is_empty = true;
				}
				else
				{
					var shape = new Triangle
					{
						SideAB = double.Parse(textBox_tri_A.Text),
						SideBC = double.Parse(textBox_tri_B.Text),
						SideCA = double.Parse(textBox_tri_B.Text)
					};
					if (shape.GetSideAB() < shape.GetSideBC() + shape.GetSideCA()
						&& shape.GetSideBC() < shape.GetSideAB() + shape.GetSideCA()
						&& shape.GetSideCA() < shape.GetSideAB() + shape.GetSideBC())
					{
						label_perimeter.Text = "Периметр: " + Convert.ToString(shape.calculatePerimeter());
						label_square.Text = "Площадь: " + Convert.ToString(shape.calculateArea());
						double angleB = Math.Acos((shape.SideAB * shape.SideAB + shape.SideBC * shape.SideBC - shape.SideCA * shape.SideCA) / (2 * shape.SideAB * shape.SideBC));
						var point1 = new Point(500, 150);
						var point2 = new Point(500 + (int)shape.SideAB * 20, 150);
						var point3 = new Point((int)(500 + shape.SideAB * 20 * Math.Cos(angleB)), (int)(150 + shape.SideAB * 20 * Math.Sin(angleB)));
						g.DrawLines(Pens.Black, new[] { point1, point2, point3, point1 });
					}
					else
					{
						MessageBox.Show("Такого треугольника не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			if (is_empty)
			{
				MessageBox.Show("Вы не ввели данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}