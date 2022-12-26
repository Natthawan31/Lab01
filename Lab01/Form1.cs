using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        int Num1, Num2, Num3;
        string op;

        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            Num.Text = Num.Text+ "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            Num.Text = Num.Text + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            Num.Text = Num.Text + "2";
        }

        private void thee_Click(object sender, EventArgs e)
        {
            Num.Text = Num.Text + "3";
        }

        private void five_Click(object sender, EventArgs e)
        {
            Num.Text = Num.Text + "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Num.Text = Num.Text + "5";

        }
        private void six_Click(object sender, EventArgs e)
        {
            Num.Text = Num.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            Num.Text = Num.Text + "7";
        }

        private void ac_Click(object sender, EventArgs e)
        {
            Num.Text = "";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Num1 = int.Parse(Num.Text);
            Num.Text = " ";
            op = "+";
        }

        private void min_Click(object sender, EventArgs e)
        {
            Num1 = int.Parse(Num.Text);
            Num.Text = " ";
            op = "-";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            Num1 = int.Parse(Num.Text);
            Num.Text = " ";
            op = "*";
        }

        private void divi_Click(object sender, EventArgs e)
        {
            Num1 = int.Parse(Num.Text);
            Num.Text = " ";
            op = "/";
        }

        private void ans_Click(object sender, EventArgs e)
        {
            Num2 = int.Parse(Num.Text);
            if (op == "+")
            {
                Num3 = Num1 + Num2;
                Num.Text = Num3.ToString();
            }//+
            if (op == "-")
            {
                Num3 = Num1 - Num2;
                Num.Text = Num3.ToString();
            }//-
            if (op == "*")
            {
                Num3 = Num1 * Num2;
                Num.Text = Num3.ToString();
            }//*
            if (op == "/")
            {
                Num3 = Num1 / Num2;
                Num.Text = Num3.ToString();
            }///


        }

        private void eight_Click(object sender, EventArgs e)
        {
            Num.Text = Num.Text + "8";

        }
        private void nine_Click(object sender, EventArgs e)
        {
            Num.Text = Num.Text + "9";
        }
    }
}
