using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGui
{
    class Ex1 : Form
    {
        TextBox t1, t2, t3;
        public Ex1()
        {
            intiate();
        }
        private void intiate()
        {
            this.Size = new Size(400, 400);
            this.Text = "Calculator";

            Label l1 = new Label();
            l1.Text = "Operand 1:";
            //l1.Size = new Size(90, 0);
            l1.Location = new Point(90, 50);

            t1 = new TextBox();
            t1.Size = new Size(100, 30);
            t1.Location = new Point(190, 50);

            Label l2=new Label();
            l2.Text = "Operand 2:";
            l2.Location = new Point(90, 120);

            t2 = new TextBox();
            t2.Size = new Size(100, 30);
            t2.Location = new Point(190, 120);

            Button b1 = new Button();
            b1.Text = "+";
            b1.Font = new Font(b1.Font.FontFamily, 30, Font.Style);
            b1.Size = new Size(60, 60);
            b1.Location = new Point(50, 170);
            b1.Click += b1_OnClick;

            Button b2 = new Button();
            b2.Text = "-";
            b2.Font = new Font(b2.Font.FontFamily, 30, Font.Style);
            b2.Size = new Size(60, 60);
            b2.Location = new Point(130, 170);
            b2.Click += b2_OnClick;

            Button b3 = new Button();
            b3.Text = "x";
            b3.Font = new Font(b3.Font.FontFamily, 30, Font.Style);
            b3.Size = new Size(60, 60);
            b3.Location = new Point(210, 170);
            b3.Click += b3_OnClick;

            Button b4 = new Button();
            b4.Text = "÷"; //Alt+0247
            b4.Font = new Font(b4.Font.FontFamily, 30, Font.Style);
            b4.Size = new Size(60, 60);
            b4.Location = new Point(290, 170);
            b4.Click += b4_OnClick;

            Label l3 = new Label();
            l3.Text = "Answer:";
            l3.Size = new Size(60, 30);
            l3.Location = new Point(90, 260);

            t3 = new TextBox();
            t3.Size = new Size(100, 30);
            t3.Location = new Point(170, 260);
            t3.ReadOnly = true;

            this.Controls.Add(l1);
            this.Controls.Add(t1);
            this.Controls.Add(l2);
            this.Controls.Add(t2);
            this.Controls.Add(b1);
            this.Controls.Add(b2);
            this.Controls.Add(b3);
            this.Controls.Add(b4);
            this.Controls.Add(l3);
            this.Controls.Add(t3);
        }
        private void b1_OnClick(object sourse, EventArgs e)
        {
            try
            {
                int x = int.Parse(t1.Text);
                int y = int.Parse(t2.Text);
                int result = x + y;
                t3.Text = result.ToString();
            }
            catch (FormatException result)
            {
                MessageBox.Show("Please enter only numbers!");
            }
        }

        private void b2_OnClick(object sourse, EventArgs e)
        {
            try
            {
                int x = int.Parse(t1.Text);
                int y = int.Parse(t2.Text);
                int result = x - y;
                t3.Text = result.ToString();
            }
            catch (FormatException result)
            {
                MessageBox.Show("Please enter only numbers!");
            }
        }

        private void b3_OnClick(object sourse, EventArgs e)
        {
            try
            {
                int x = int.Parse(t1.Text);
                int y = int.Parse(t2.Text);
                int result = x * y;
                t3.Text = result.ToString();
            }
            catch (FormatException result)
            {
                MessageBox.Show("Please enter only numbers!");
            }
        }


        private void b4_OnClick(object sourse, EventArgs e)
        {
            try
            {
                int x = int.Parse(t1.Text);
                int y = int.Parse(t2.Text);
                int result = x / y;
                t3.Text = result.ToString();
            }
            catch (DivideByZeroException y)
            {
                //Console.WriteLine("can't divide by zero!");
                MessageBox.Show("Can't divide by zero!");
            }
            catch(FormatException result)
            {
                MessageBox.Show("Please enter only numbers!");
            }
            catch(Exception result)
            {
                MessageBox.Show("Something went wrong!");
            }
        }
    }
}
