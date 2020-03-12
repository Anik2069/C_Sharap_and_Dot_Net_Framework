﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Variables  ........................................

        public string[] strings = new string[20];
        public double[] numbers = new double[20];

        public int counter = 0;
        public string arithmetic_operator = "";
        int resultCheck = 0; // checks if result is used as a number
        int dotCheck = 0; // checks if there is already a dot int the number

        //btn press methods ...................................

        public void clear()
        {
            for (int i = 0; i < 20; i++)
            {
                strings[i] = "";
                numbers[i] = 0.0;
            }



            counter = 0;
            arithmetic_operator = null;
            resultCheck = 0; // checks if result is used as a number
            dotCheck = 0; // checks if there is already a dot int the number 
            textBox1.Text = "";
        }
        public void btnPress(string num)
        {
            if (num.Equals(".") && dotCheck == 0)
            {
                this.textBox1.AppendText(num);
                strings[counter] = strings[counter] + num;
                dotCheck = 1;
                resultCheck = 0;
            }
            else if (num.Equals(".") && dotCheck != 0)
            {

            }
            else
            {
                this.textBox1.AppendText(num);
                strings[counter] = strings[counter] + num;
                resultCheck = 0;
            }
        }
        public void arithmeticBtnPress(string sign)
        {
            if (!arithmetic_operator.Equals(""))
            {
                equalBtnPress();
            }
            this.textBox1.AppendText(Environment.NewLine);
            this.textBox1.AppendText(sign);
            this.textBox1.AppendText(Environment.NewLine);

            arithmetic_operator = sign;
            dotCheck = 0;
            if (resultCheck == 0)
            {

                numbers[counter] = double.Parse(strings[counter]);
                counter++;
            }
        }
        public void equalBtnPress()
        {

            numbers[counter] = double.Parse(strings[counter]);

            this.textBox1.AppendText(Environment.NewLine);
            this.textBox1.AppendText("=");
            double result = 0.0;
            switch (arithmetic_operator)
            {
                case "+":
                    result = numbers[counter] + numbers[counter - 1];
                    break;
                case "-":
                    result = numbers[counter] - numbers[counter - 1];
                    break;
                case "/":
                    result = numbers[counter] / numbers[counter - 1];
                    break;
                case "*":
                    result = numbers[counter] * numbers[counter - 1];
                    break;
            }

            this.textBox1.AppendText(result.ToString("F6"));
            dotCheck = 0;
            counter++;
            //string[counter] = result.ToString("F6");
            numbers[counter] = result;


            this.textBox1.AppendText(Environment.NewLine);
            counter++;
            resultCheck = 1;
            arithmetic_operator = "";

        }
        public void sciBtnPress(string sign)
        {
            if (!string.IsNullOrEmpty(strings[counter]))
            {
                numbers[counter] = double.Parse(strings[counter]);
            }
            else
            {
                counter--;
            }
            this.textBox1.AppendText(Environment.NewLine);
  
            double result = 0.0;
            switch (sign)
            {
                case "sin":
                    result = Math.Sin(numbers[counter]);
                    break;
                case "cos":
                    result = Math.Cos(numbers[counter]);
                    break;
                case "tan":
                    result = Math.Tan(numbers[counter]);
                    break;
                case "log":
                    result = Math.Log10(numbers[counter]);
                    break;
                case "sqrt":
                    result = Math.Sqrt(numbers[counter]);
                    break;
            }
            this.textBox1.AppendText(sign+"=");
            this.textBox1.AppendText(result.ToString("F6"));
            dotCheck = 0;
            counter++;
            //string[counter] = result.ToString("F6");
            numbers[counter] = result;


            this.textBox1.AppendText(Environment.NewLine);
            counter++;
            resultCheck = 1;
            
        }


        //btn press events .....................................


        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.btnPress(btn.Text);
            //this.textBox1.AppendText(btn.Text);
            //this.textBox1.Text=strings[counter];

        }



        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            arithmeticBtnPress(btn.Text);
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            equalBtnPress();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
                f1.Closed += (s, args) => this.Close();

        }

        private void sciBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            sciBtnPress(btn.Text);
        }
    }
}