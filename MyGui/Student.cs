using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGui
{
    public class Student
    {
        
    }

    class StudCourseForm : Form
    {
        public StudCourseForm(){
            intialize();
        }
        private void intialize() {
            this.Text = "Test";
            this.Size = new Size(410, 300);

            Label L = new Label();
            L.Text = "Student/Course";
            L.Location = new Point(10, 20);

            Label l1 = new Label();
            l1.Text = "First Name";
            l1.Location = new Point(10, 60);

            TextBox t1 = new TextBox();
            t1.Size = new Size(90, 30);
            t1.Location = new Point(110, 60);

            Label l2 = new Label();
            l2.Text = "Last Name";
            l2.Location = new Point(10, 95);

            TextBox t2 = new TextBox();
            t2.Size = new Size(90, 30);
            t2.Location = new Point(110, 95);

            ComboBox cb1 = new ComboBox();
            cb1.Items.Add("Male");
            cb1.Items.Add("Female");
            cb1.Location = new Point(10, 135);


            RadioButton rb1 = new RadioButton();
            rb1.Text = "Under Graguate";
            rb1.Size = new Size(140, 30);
            rb1.Location = new Point(10, 160);

            RadioButton rb2 = new RadioButton();
            rb2.Text = "Graguated";
            rb2.Location = new Point(150, 160);

            CheckBox Ch1 = new CheckBox();
            Ch1.Text = "Device";
            Ch1.Location = new Point(10, 190);

            CheckBox Ch2 = new CheckBox();
            Ch2.Text = "C++";
            Ch2.Location = new Point(120, 190);

            Button b1 = new Button();
            b1.Text = "Save";
            b1.Location = new Point(10, 220);

            Button b2 = new Button();
            b2.Text = "Display";
            b2.Location=new Point(230, 220);

            Button b3 = new Button();
            b3.Text = "Exit";
            b3.Location = new Point(120, 230);
            //b3.Enabled = false;
            b3.Click += B3_Click;

            Label l3 = new Label();
            l3.Text = "Display Profile";
            l3.Location = new Point(210, 60);

            ListBox li = new ListBox();
            li.Location = new Point(260, 90);
            li.Items.Add("Morning");
            li.Items.Add("Evening");


            this.Controls.Add(L);
            this.Controls.Add(l1);
            this.Controls.Add(t1);
            this.Controls.Add(l2);
            this.Controls.Add(t2);
            this.Controls.Add(cb1);
            this.Controls.Add(rb1);
            this.Controls.Add(rb2);
            this.Controls.Add(Ch1);
            this.Controls.Add(Ch2);
            this.Controls.Add(b1);
            this.Controls.Add(b2);
            this.Controls.Add(b3);
            this.Controls.Add(l3);
            this.Controls.Add(li);
        }

        private void B1_OnClick(object source, EventArgs e)
        {

        } 

        private void B2_OnClick(object source,EventArgs e)
        {

        }
        private void B3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
