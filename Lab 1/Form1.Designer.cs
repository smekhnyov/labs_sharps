using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSH_Lab1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button_square = new Button();
			button_circle = new Button();
			button_triangle = new Button();
			button_rectangle = new Button();
			groupBox_square = new GroupBox();
			label1 = new Label();
			textBox_square = new TextBox();
			groupBox_rectangle = new GroupBox();
			textBox_rect_B = new TextBox();
			textBox_rect_A = new TextBox();
			label4 = new Label();
			groupBox_circle = new GroupBox();
			textBox_circle = new TextBox();
			label2 = new Label();
			groupBox_triangle = new GroupBox();
			textBox_tri_C = new TextBox();
			textBox_tri_B = new TextBox();
			textBox_tri_A = new TextBox();
			label3 = new Label();
			label_square = new Label();
			label_perimeter = new Label();
			button_ok = new Button();
			button1 = new Button();
			richTextBox1 = new RichTextBox();
			button2 = new Button();
			button3 = new Button();
			groupBox_square.SuspendLayout();
			groupBox_rectangle.SuspendLayout();
			groupBox_circle.SuspendLayout();
			groupBox_triangle.SuspendLayout();
			SuspendLayout();
			// 
			// button_square
			// 
			button_square.Location = new Point(13, 27);
			button_square.Name = "button_square";
			button_square.Size = new Size(110, 23);
			button_square.TabIndex = 0;
			button_square.Text = "Квадрат";
			button_square.UseVisualStyleBackColor = true;
			button_square.Click += button_square_Click;
			// 
			// button_circle
			// 
			button_circle.Location = new Point(13, 69);
			button_circle.Name = "button_circle";
			button_circle.Size = new Size(110, 23);
			button_circle.TabIndex = 1;
			button_circle.Text = "Круг";
			button_circle.UseVisualStyleBackColor = true;
			button_circle.Click += button_circle_Click;
			// 
			// button_triangle
			// 
			button_triangle.Location = new Point(13, 111);
			button_triangle.Name = "button_triangle";
			button_triangle.Size = new Size(110, 23);
			button_triangle.TabIndex = 2;
			button_triangle.Text = "Треугольник";
			button_triangle.UseVisualStyleBackColor = true;
			button_triangle.Click += button_triangle_Click;
			// 
			// button_rectangle
			// 
			button_rectangle.Location = new Point(13, 153);
			button_rectangle.Name = "button_rectangle";
			button_rectangle.Size = new Size(110, 23);
			button_rectangle.TabIndex = 3;
			button_rectangle.Text = "Прямоугольник";
			button_rectangle.UseVisualStyleBackColor = true;
			button_rectangle.Click += button_rectangle_Click;
			// 
			// groupBox_square
			// 
			groupBox_square.Controls.Add(label1);
			groupBox_square.Controls.Add(textBox_square);
			groupBox_square.Location = new Point(134, 27);
			groupBox_square.Name = "groupBox_square";
			groupBox_square.Size = new Size(233, 158);
			groupBox_square.TabIndex = 4;
			groupBox_square.TabStop = false;
			groupBox_square.Text = "Квадрат";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(24, 47);
			label1.Name = "label1";
			label1.Size = new Size(98, 15);
			label1.TabIndex = 1;
			label1.Text = "Введите сторону";
			// 
			// textBox_square
			// 
			textBox_square.Location = new Point(24, 65);
			textBox_square.Name = "textBox_square";
			textBox_square.Size = new Size(100, 23);
			textBox_square.TabIndex = 0;
			// 
			// groupBox_rectangle
			// 
			groupBox_rectangle.Controls.Add(textBox_rect_B);
			groupBox_rectangle.Controls.Add(textBox_rect_A);
			groupBox_rectangle.Controls.Add(label4);
			groupBox_rectangle.Location = new Point(134, 27);
			groupBox_rectangle.Name = "groupBox_rectangle";
			groupBox_rectangle.Size = new Size(233, 158);
			groupBox_rectangle.TabIndex = 5;
			groupBox_rectangle.TabStop = false;
			groupBox_rectangle.Text = "Прямоугольник";
			groupBox_rectangle.Visible = false;
			// 
			// textBox_rect_B
			// 
			textBox_rect_B.Location = new Point(23, 94);
			textBox_rect_B.Name = "textBox_rect_B";
			textBox_rect_B.Size = new Size(100, 23);
			textBox_rect_B.TabIndex = 2;
			// 
			// textBox_rect_A
			// 
			textBox_rect_A.Location = new Point(23, 65);
			textBox_rect_A.Name = "textBox_rect_A";
			textBox_rect_A.Size = new Size(100, 23);
			textBox_rect_A.TabIndex = 1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(21, 41);
			label4.Name = "label4";
			label4.Size = new Size(101, 15);
			label4.TabIndex = 0;
			label4.Text = "Введите стороны";
			// 
			// groupBox_circle
			// 
			groupBox_circle.Controls.Add(textBox_circle);
			groupBox_circle.Controls.Add(label2);
			groupBox_circle.Location = new Point(134, 27);
			groupBox_circle.Name = "groupBox_circle";
			groupBox_circle.Size = new Size(233, 158);
			groupBox_circle.TabIndex = 2;
			groupBox_circle.TabStop = false;
			groupBox_circle.Text = "Круг";
			groupBox_circle.Visible = false;
			// 
			// textBox_circle
			// 
			textBox_circle.Location = new Point(24, 65);
			textBox_circle.Name = "textBox_circle";
			textBox_circle.Size = new Size(100, 23);
			textBox_circle.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(24, 47);
			label2.Name = "label2";
			label2.Size = new Size(91, 15);
			label2.TabIndex = 0;
			label2.Text = "Введите радиус";
			// 
			// groupBox_triangle
			// 
			groupBox_triangle.Controls.Add(textBox_tri_C);
			groupBox_triangle.Controls.Add(textBox_tri_B);
			groupBox_triangle.Controls.Add(textBox_tri_A);
			groupBox_triangle.Controls.Add(label3);
			groupBox_triangle.Location = new Point(134, 27);
			groupBox_triangle.Name = "groupBox_triangle";
			groupBox_triangle.Size = new Size(233, 158);
			groupBox_triangle.TabIndex = 2;
			groupBox_triangle.TabStop = false;
			groupBox_triangle.Text = "Треугольник";
			groupBox_triangle.Visible = false;
			// 
			// textBox_tri_C
			// 
			textBox_tri_C.Location = new Point(24, 123);
			textBox_tri_C.Name = "textBox_tri_C";
			textBox_tri_C.Size = new Size(100, 23);
			textBox_tri_C.TabIndex = 3;
			// 
			// textBox_tri_B
			// 
			textBox_tri_B.Location = new Point(24, 94);
			textBox_tri_B.Name = "textBox_tri_B";
			textBox_tri_B.Size = new Size(100, 23);
			textBox_tri_B.TabIndex = 2;
			// 
			// textBox_tri_A
			// 
			textBox_tri_A.Location = new Point(24, 65);
			textBox_tri_A.Name = "textBox_tri_A";
			textBox_tri_A.Size = new Size(100, 23);
			textBox_tri_A.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(22, 41);
			label3.Name = "label3";
			label3.Size = new Size(101, 15);
			label3.TabIndex = 0;
			label3.Text = "Введите стороны";
			// 
			// label_square
			// 
			label_square.AutoSize = true;
			label_square.Location = new Point(13, 720);
			label_square.Name = "label_square";
			label_square.Size = new Size(65, 15);
			label_square.TabIndex = 6;
			label_square.Text = "Площадь: ";
			// 
			// label_perimeter
			// 
			label_perimeter.AutoSize = true;
			label_perimeter.Location = new Point(189, 720);
			label_perimeter.Name = "label_perimeter";
			label_perimeter.Size = new Size(69, 15);
			label_perimeter.TabIndex = 7;
			label_perimeter.Text = "Периметр: ";
			// 
			// button_ok
			// 
			button_ok.Location = new Point(13, 195);
			button_ok.Name = "button_ok";
			button_ok.Size = new Size(110, 23);
			button_ok.TabIndex = 8;
			button_ok.Text = "OK";
			button_ok.UseVisualStyleBackColor = true;
			button_ok.Click += button_ok_Click;
			// 
			// button1
			// 
			button1.Location = new Point(13, 237);
			button1.Name = "button1";
			button1.Size = new Size(108, 23);
			button1.TabIndex = 9;
			button1.Text = "Числа";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(9, 401);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(240, 96);
			richTextBox1.TabIndex = 10;
			richTextBox1.Text = "";
			// 
			// button2
			// 
			button2.Location = new Point(13, 279);
			button2.Name = "button2";
			button2.Size = new Size(108, 23);
			button2.TabIndex = 11;
			button2.Text = "Строки";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(13, 321);
			button3.Name = "button3";
			button3.Size = new Size(108, 23);
			button3.TabIndex = 12;
			button3.Text = "Фигуры";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(849, 744);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(richTextBox1);
			Controls.Add(button1);
			Controls.Add(button_ok);
			Controls.Add(label_perimeter);
			Controls.Add(label_square);
			Controls.Add(button_rectangle);
			Controls.Add(button_triangle);
			Controls.Add(button_circle);
			Controls.Add(button_square);
			Controls.Add(groupBox_square);
			Controls.Add(groupBox_circle);
			Controls.Add(groupBox_triangle);
			Controls.Add(groupBox_rectangle);
			Name = "Form1";
			Text = "Form1";
			Paint += Form1_Paint;
			groupBox_square.ResumeLayout(false);
			groupBox_square.PerformLayout();
			groupBox_rectangle.ResumeLayout(false);
			groupBox_rectangle.PerformLayout();
			groupBox_circle.ResumeLayout(false);
			groupBox_circle.PerformLayout();
			groupBox_triangle.ResumeLayout(false);
			groupBox_triangle.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button_square;
		private Button button_circle;
		private Button button_triangle;
		private Button button_rectangle;
		private GroupBox groupBox_square;
		private TextBox textBox_square;
		private Label label1;
		private GroupBox groupBox_circle;
		private TextBox textBox_circle;
		private Label label2;
		private GroupBox groupBox_triangle;
		private TextBox textBox_tri_C;
		private TextBox textBox_tri_B;
		private TextBox textBox_tri_A;
		private Label label3;
		private GroupBox groupBox_rectangle;
		private TextBox textBox_rect_B;
		private TextBox textBox_rect_A;
		private Label label4;
		private Label label_square;
		private Label label_perimeter;
		private Button button_ok;
		private Button button1;
		private RichTextBox richTextBox1;
		private Button button2;
		private Button button3;
	}
}