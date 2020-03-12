using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalCulator
{
    public partial class Form1 : Form
    {
        String[] s=new String[10];
        int d = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int re=0;
        int sc = 0;
        String[] si = new String[100];
        
        public void calculation(String i)
        {
           
            int c=0 ;
            int m = 1;
            String q;
            
            if (i.Equals("+"))
            {
                c = Convert.ToInt16(s[d - 1]);
                re = re + c;
                si[sc] = i;
            }
            else if (i.Equals("-"))
            {
                c = Convert.ToInt16(s[d - 1]);
                re = c - re;
                si[sc] = i;

            }
            else if(i.Equals("*"))
            {
                c = Convert.ToInt16(s[d - 1]);
                re = re * m;
                si[sc] = i;

            }
            else if (i.Equals("/"))
            {
                c = Convert.ToInt16(s[d - 1]);
                re = re + c;
                si[sc] = i;

            }
            else if (i.Equals("="))
            {
                c = Convert.ToInt16(s[d - 1]);
                if (si[sc].Equals("+"))
                {

                    re = re + c;

                }
                else if (si[sc].Equals("-"))
                {

                    re = re - c;

                }
                else if (si[sc].Equals("*"))
                {

                    re = re * c* m;

                }
                else if (si[sc].Equals("/"))
                {

                    re = re / c;

                }
                this.textBox1.AppendText(Environment.NewLine);
                this.textBox1.AppendText(re.ToString());
               
            }
            else
            {
                
                if (i.Equals(s[d - 1]))
                {
                    q = s[d - 1] + i;
                    s[d-1] = q;
                }
                else
                {
                    s[d] = i;
                    d = d + 1;
                    

                }


            }
            
         


        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.textBox1.Clear();
            re = 0;
            d = 1;
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Text;
            
            this.textBox1.AppendText(a);
            calculation(a);


        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Text;
            

            this.textBox1.AppendText(a);
            calculation(a);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Text;
          

            this.textBox1.AppendText(a);
            calculation(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Text;

            this.textBox1.AppendText(a);
            calculation(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Text;

            this.textBox1.AppendText(a);
            calculation(a);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Text;

            this.textBox1.AppendText(a);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Text;
            
            this.textBox1.AppendText(a);
            calculation(a);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Text;

            this.textBox1.AppendText(a);
            calculation(a);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Text;


            this.textBox1.AppendText(a);
            calculation(a);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Text;

            this.textBox1.AppendText(a);
            calculation(a);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Text;

            this.textBox1.AppendText(a);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Text;

            this.textBox1.AppendText(a);
            calculation(a);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Text;

            this.textBox1.AppendText(a);
            calculation(a);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Text;

            this.textBox1.AppendText(a);
            calculation(a);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Text;

            this.textBox1.AppendText(a);
            calculation(a);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Text;

            this.textBox1.AppendText(a);
            calculation(a);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Text;

            this.textBox1.AppendText(a);
            calculation(a);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
