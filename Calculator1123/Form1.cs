using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1123
{
    public partial class Form1 : Form
    {
        // 전역변수 Globla Variable
        int m_First;
        string m_Opeator = "";
        bool m_OperatorClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if(m_OperatorClicked == false)
            {
                textBox1.Text = textBox1.Text + "9";
            }
            else
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "9";
                m_OperatorClicked = false;
            }
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (m_OperatorClicked == false)
            {
                textBox1.Text = textBox1.Text + "8";
            }
            else
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "8";
                m_OperatorClicked = false;
            }
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (m_OperatorClicked == false)
            {
                textBox1.Text = textBox1.Text + "7";
            }
            else
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "7";
                m_OperatorClicked = false;
            }
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (m_OperatorClicked == false)
            {
                textBox1.Text = textBox1.Text + "6";
            }
            else
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "6";
                m_OperatorClicked = false;
            }
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (m_OperatorClicked == false)
            {
                textBox1.Text = textBox1.Text + "5";
            }
            else
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "5";
                m_OperatorClicked = false;
            }
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (m_OperatorClicked == false)
            {
                textBox1.Text = textBox1.Text + "4";
            }
            else
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "4";
                m_OperatorClicked = false;
            }
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (m_OperatorClicked == false)
            {
                textBox1.Text = textBox1.Text + "3";
            }
            else
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "3";
                m_OperatorClicked = false;
            }
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (m_OperatorClicked == false)
            {
                textBox1.Text = textBox1.Text + "2";
            }
            else
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "2";
                m_OperatorClicked = false;
            }
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (m_OperatorClicked == false)
            {
                textBox1.Text = textBox1.Text + "1";
            }
            else
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "1";
                m_OperatorClicked = false;
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (m_OperatorClicked == false)
            {
                textBox1.Text = textBox1.Text + "0";
            }
            else
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text + "0";
                m_OperatorClicked = false;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            m_First = 0;
            m_Opeator = "";
            m_OperatorClicked = false;
            textBox1.Text = "";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            //지역변수
            m_First = int.Parse(textBox1.Text);
            m_Opeator = "+";
            m_OperatorClicked = true;
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            //지역변수
            m_First = int.Parse(textBox1.Text);
            m_Opeator = "-";
            m_OperatorClicked = true;
        }

        private void buttonMultifly_Click(object sender, EventArgs e)
        {
            //지역변수
            m_First = int.Parse(textBox1.Text);
            m_Opeator = "*";
            m_OperatorClicked = true;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            //지역변수
            m_First = int.Parse(textBox1.Text);
            m_Opeator = "/";
            m_OperatorClicked = true;
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            // first + second
            if(m_Opeator == "+")
            {
                int second = int.Parse(textBox1.Text);
                int result = m_First + second;
                textBox1.Text = result.ToString();
            }
            else if (m_Opeator == "-")
            {
                int second = int.Parse(textBox1.Text);
                int result = m_First - second;
                textBox1.Text = result.ToString();
            }
            else if (m_Opeator == "*")
            {
                int second = int.Parse(textBox1.Text);
                int result = m_First * second;
                textBox1.Text = result.ToString();
            }
            else if(m_Opeator == "/")
            {
                int second = int.Parse(textBox1.Text);
                if( second == 0)
                {
                    textBox1.Text = "0으로 나눌수 없습니다.";
                }
                else 
                { 
                int result = m_First / second;
                textBox1.Text = result.ToString();
                }
            }
        }
    }
}
