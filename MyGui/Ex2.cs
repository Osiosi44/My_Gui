using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGui
{
    public class Ex2 : Form
    {
        private TextBox t1;
        private Label l2;
        private RichTextBox rt1;
        public Ex2()
        {
            intial();
        }

        private void intial()
        {
            this.Text = "Convert Celsius to Fahrenheit";
            this.Size = new Size(500, 450);

            Label l1 = new Label();
            l1.Text = "Formula: farhaniet = (9/5) * celsius + 32";
            l1.Font = new Font(l1.Font.FontFamily, 11, l1.Font.Style | FontStyle.Bold);
            l1.Size = new Size(300, 35);
            l1.Location = new Point(100, 20);

            t1 = new TextBox();
            t1.Size = new Size(300, 30);
            t1.Location=new Point(100, 60);

            Button b1 = new Button();
            b1.Text = "To fahrenheit";
            b1.Size = new Size(100, 50);
            b1.Location = new Point(100, 105);

            b1.Click += b1_OnClick;

            Button b2 = new Button();
            b2.Text = "To Celsius";
            b2.Size=new Size(100, 50);
            b2.Location = new Point(300, 105);

            b2.Click += b2_OnClick;


            l2 = new Label();
            l2.Text = "Conversion Result: ?";
            //Font size adjustment
            l2.Font=new Font(l2.Font.FontFamily,14,l2.Font.Style | FontStyle.Italic);
            //l2.Font = new Font(l2.Font.FontFamily,l2.Font.Size + 13, l2.Font.Style | FontStyle.Bold);

            l2.Size = new Size(200, 50);
            l2.Location = new Point(170, 165);

            Button b3 = new Button();
            b3.Text = "Exit";
            b3.Size = new Size(50, 40);
            b3.Location = new Point(420, 165);

            Label l3 = new Label();
            l3.Text = "History";
            l3.Size = new Size(100, 20);
            l3.Location = new Point(100, 230);

            rt1 = new RichTextBox();
            rt1.ReadOnly = true;
            rt1.Size = new Size(300, 100);
            rt1.Location = new Point(100, 250);

            b3.Click += b3_OnClick;

            this.Controls.Add(l1);
            this.Controls.Add(t1);
            this.Controls.Add(b1);
            this.Controls.Add(b2);
            this.Controls.Add(l2);
            this.Controls.Add(b3);
            this.Controls.Add(l3);
            this.Controls.Add(rt1);

        }
        private void b1_OnClick(object source, EventArgs e)
        {
            double x = double.Parse(t1.Text);
            double result = (x * 9 / 5) + 32;
            //MessageBox.Show("The fahrenheit of " + x + " is " + result + "!");
            l2.Text = "Conversion Result: " + result.ToString();
            rt1.AppendText(result.ToString() + "\n");
        }
        private void b2_OnClick(object source, EventArgs e)
        {
            double x = double.Parse(t1.Text);
            double result = ((x - 32) * 5 / 9);
            //MessageBox.Show("The celsius of " + x + " is " + result + "!");
            l2.Text = "Conversion Result: " + result.ToString();
            rt1.AppendText (result.ToString()+"\n");
        }
        private void b3_OnClick(object source, EventArgs e)
        {
            Application.Exit();
        }
    }
}