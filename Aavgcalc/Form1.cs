using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
//using System.Data.
using System.IO; 

namespace Aavgcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            if (m1t.Text == ""||
            m2t.Text == ""||
            m3t.Text == ""||
            m4t.Text == ""||
            t1t.Text == "")
            {
               MessageBox.Show("Please enter all marks to calculate the marks !!");
            }
            else
            {
                float m1 = float.Parse(m1t.Text);
                float m2 = float.Parse(m2t.Text);
                float m3 = float.Parse(m3t.Text);
                float m4 = float.Parse(m4t.Text);
                float ft = float.Parse(t1t.Text);
                t2tt.Text = (m1+m2+m3+m4).ToString();
                float st= float.Parse(t2tt.Text);
                avgtt.Text = ((ft + st) / 2).ToString();
            }

        }

        private void clearbt_Click(object sender, EventArgs e)
        {
            m1t.Text = "";
            m2t.Text = "";
            m3t.Text = "";
            m4t.Text = "";
            t1t.Text = "";
            t2tt.Text = "";
            avgtt.Text = "";
        }






    }
}
