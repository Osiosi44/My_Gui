using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGui
{
    public class Code : Form
    {
        private Button B1;
        private TextBox T1;
        
        public Code()
        {
            InitializeComponent();
        }

        private void InitializeComponent() {
            //form properties
            this.Text = "Firt Gui";
            this.Size = new System.Drawing.Size(600, 600);
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;

            Label L1 = new Label();
            L1.Text = "Name:";
            L1.Size = new System.Drawing.Size(40, 30);
            L1.Location = new System.Drawing.Point(10, 30);

            T1 = new TextBox();
            T1.Size = new System.Drawing.Size(100, 20);
            T1.Location = new System.Drawing.Point(50, 30);

            TextBox T2 = new TextBox();
            T2.Size=new Size(100, 200);
            T2.Location=new Point(150, 120);

            Label L2 = new Label();
            L2.Text = "Saved";
            L2.Size = new Size(40, 30);
            L2.Location = new Point(100, 120);

            B1 = new Button();
            B1.Text = "Name Button";
            B1.Size = new System.Drawing.Size(100, 30);
            B1.Location = new System.Drawing.Point(100, 70);

            Label L3 = new Label();
            L3.Text = "Listbox";
            L3.Size = new Size(60, 30);
            L3.Location = new Point(30, 350);

            ListBox Li = new ListBox();
            Li.Size = new Size(100, 100);
            Li.Location = new Point(100, 350);

            B1.Click += Button_OnClick;

            
            this.Controls.Add(L1);
            this.Controls.Add(T1);
            this.Controls.Add(B1);
            this.Controls.Add(L2);
            this.Controls.Add(T2);
            this.Controls.Add(Li);
        }
        private void Button_OnClick(object sender, EventArgs e)
        {
            string name = T1.Text;
            MessageBox.Show("hello, " + name + "!");
        }
    }
}
