using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MyGui
{
    public class Ex3 : Form
    {
        TextBox t1;
        RichTextBox rtb1;
        Label l2, l3, l4;
        public Ex3()
        {
            intial();
        }
        private void intial()
        {
            this.Text = "Programmer Calculator";
            this.Size = new Size(500, 400);

            Label l1 = new Label();
            l1.Text = "Enter Decimal Value";
            l1.Font = new Font(l1.Font.FontFamily, 14, FontStyle.Bold | FontStyle.Italic);
            l1.Size = new Size(300, 50);
            l1.Location = new Point(100, 30);

            t1 = new TextBox();
            t1.Size = new Size(300, 0);
            t1.Location = new Point(100, 90);

            Button b1 = new Button();
            b1.Text = "Convert";
            b1.Size = new Size(300, 50);
            b1.Location = new Point(100, 120);

            b1.Click += b1_OnClick;
            
            b1.KeyDown += b1_KeyDown;

            l2 = new Label();
            l2.Text = "HEX";
            l2.Size = new Size(100, 30);
            l2.Location = new Point(100, 200);

            l3 = new Label();
            l3.Text = "OCT";
            l3.Size = new Size(100, 30);
            l3.Location = new Point(100, 230);

            l4 = new Label();
            l4.Text = "BIN";
            l4.Size = new Size(100, 30);
            l4.Location = new Point(100, 260);

            this.Controls.Add(l1);
            this.Controls.Add(t1);
            this.Controls.Add(b1);
            this.Controls.Add(l2);
            this.Controls.Add(l3);
            this.Controls.Add(l4);
        }
        private void b1_OnClick(object source, EventArgs e)
        {
            int x = int.Parse(t1.Text);
            string hex, oct, bin;
            hex = x.ToString("X");
            oct = Convert.ToString(x,8);
            bin = Convert.ToString(x,2);
            
            l2.Text = "HEX: " + hex.ToString();
            l3.Text = "OCT: " + oct.ToString();
            l4.Text = "BIN: " + bin.ToString();
        }

        private void perform()
        {
            int x = int.Parse(t1.Text);
            string hex, oct, bin;
            hex = x.ToString("X");
            oct = Convert.ToString(x, 8);
            bin = Convert.ToString(x, 2);

            l2.Text = "HEX: " + hex.ToString();
            l3.Text = "OCT: " + oct.ToString();
            l4.Text = "BIN: " + bin.ToString();
        }
        private void b1_KeyDown(object source, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                perform();
            }
            else
                MessageBox.Show("Not Entering!");
        }
    }
}
