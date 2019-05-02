using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_win
{
	public partial class Form1 : Form
	{
		int flag = 0;
		float temp = 0;
		int first = 1;
		
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			textBox1.Text = "";
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void numButton_click(object sender, EventArgs e)
		{
			if (first == 1)
			{
				textBox1.Text = "";
				first = 0;
			}
			if (((Button)sender).Text == ".")
			{
				if (flag == 0)
				{
					if (textBox1.Text == "")
					{
						textBox1.Text = "0";
					}
					textBox1.Text += ((Button)sender).Text;
					flag = 1;
				}
			}
			else
				textBox1.Text += ((Button)sender).Text;
		}

		private void operaButton_click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			Console.WriteLine(btn.Name);
			textBox2.Text = textBox1.Text+((Button)sender).Text;
			float a = Convert.ToSingle(textBox1.Text);
			
			/*
			switch (btn.Name)
			{
				case "a":
					textBox1.Text = Convert.ToString(a + temp);
					temp = a + temp;
					break;
				case "b":
					textBox1.Text = Convert.ToString(temp - a);
					temp = temp - a;
					break;
				case "c":
					textBox1.Text = Convert.ToString(temp * a);
					temp = temp * a;
					break;
				case "d":
					textBox1.Text = Convert.ToString(temp / a);
					temp = temp / a;
					break;
				
			}
			*/
			flag = 0;
			first = 1;
		}


		private void label1_DoubleClick(object sender, EventArgs e)
		{
			temp = 0;
			textBox1.Text = "";
			textBox2.Text = "";
			flag = 0;
		}

		private void label1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			flag = 0;
		}

		private void g_Click(object sender, EventArgs e)
		{
			string opera = this.textBox2.Text.Substring(textBox2.Text.Length - 1, 1);
			Console.WriteLine(opera);
			float b = Convert.ToSingle(textBox1.Text);
			float temp = Convert.ToSingle(textBox2.Text.Substring(0, textBox2.Text.Length - 1));
			switch(opera)
			{
				case "+":
					textBox1.Text = Convert.ToString(temp + b);
					break;
				case "-":
					textBox1.Text = Convert.ToString(temp - b);
					break;
				case "x":
					textBox1.Text = Convert.ToString(temp * b);
					break;
				case "/":
					textBox1.Text = Convert.ToString(temp / b);
					break;
				case "^":
					textBox1.Text = Convert.ToString(Math.Pow(temp, b));
					break;
			}
			textBox2.Text = "";
		}

		private void e_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				textBox1.Text = "0";
			}
			textBox1.Text = Convert.ToString(Convert.ToSingle(textBox1.Text)/100);
			flag = 1;
		}

		private void f_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				return;
			}
			textBox1.Text = Convert.ToString(-Convert.ToSingle(textBox1.Text));
		}

		private void h_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				return;
			}
			textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToSingle(textBox1.Text)));
		}

		private void sin_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				return;
			}
			textBox1.Text = Convert.ToString(Math.Sin(Math.PI * Convert.ToSingle(textBox1.Text) / 180));
		}

		private void Cos_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				return;
			}
			textBox1.Text = Convert.ToString(Math.Cos(Math.PI * Convert.ToSingle(textBox1.Text) / 180));
		}

		private void Factorial_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				return;
			}
			try
			{
				int a = Convert.ToInt32(textBox1.Text);
				if (a < 0) throw new Exception("无效输入！");
				else if (a == 0) textBox1.Text = "1";
				else
				{
					long res = 1;
					for (int i = 1; i <= a; i++)
					{
						res = res * i;
					}
					textBox1.Text = Convert.ToString(res);
				}
			}
			catch
			{
				textBox1.Text = "无效输入！";
				first = 1;
			}
		}

		private void Reciprocal_Click(object sender, EventArgs e)
		{
			try
			{
				if (textBox1.Text == "0" || textBox1.Text == "") throw new Exception("倒数无意义");
				else
				{
					textBox1.Text = Convert.ToString(1 / Convert.ToSingle(textBox1.Text));
				}
			}
			catch
			{
				textBox1.Text = "倒数无意义";
				first = 1;
			}
		}

		private void Asin_Click(object sender, EventArgs e)
		{
			textBox1.Text = Convert.ToString(Math.Asin(Convert.ToSingle(textBox1.Text))/Math.PI*180);
		}

		private void Acos_Click(object sender, EventArgs e)
		{
			textBox1.Text = Convert.ToString(Math.Acos(Convert.ToSingle(textBox1.Text))/Math.PI*180);
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '0')
			{
				button8.PerformClick();
				e.Handled = true;
			}
			if (e.KeyChar == '.')
			{
				button18.PerformClick();
				e.Handled = true;
			}
			if (e.KeyChar == '1')
			{
				button10.PerformClick();
				e.Handled = true;
			}
			if (e.KeyChar == '2')
			{
				button13.PerformClick();
				e.Handled = true;
			}
			if (e.KeyChar == '3')
			{
				button17.PerformClick();
				e.Handled = true;
			}
			if (e.KeyChar == '4')
			{
				button7.PerformClick();
				e.Handled = true;
			}
			if (e.KeyChar == '5')
			{
				button12.PerformClick();
				e.Handled = true;
			}
			if (e.KeyChar == '6')
			{
				button16.PerformClick();
				e.Handled = true;
			}
			if (e.KeyChar == '7')
			{
				button6.PerformClick();
				e.Handled = true;
			}
			if (e.KeyChar == '8')
			{
				button11.PerformClick();
				e.Handled = true;
			}
			if (e.KeyChar == '9')
			{
				button14.PerformClick();
				e.Handled = true;
			}
			if (e.KeyChar == '+')
			{
				a.PerformClick();
				e.Handled = true;
			}
			if (e.KeyChar == '-')
			{
				b.PerformClick();
				e.Handled = true;
			}
			if (e.KeyChar == 'x')
			{
				c.PerformClick();
				e.Handled = true;
			}
			if (e.KeyChar == '/')
			{
				d.PerformClick();
				e.Handled = true;
			}
			if (e.KeyChar == '^')
			{
				button21.PerformClick();
				e.Handled = true;
			}
			if (e.KeyChar== (char)13)
			{
				eq.PerformClick();
				e.Handled = true;
			}
		}
	}
}
