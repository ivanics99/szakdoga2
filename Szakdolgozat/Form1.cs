using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szakdolgozat
{
    public partial class Form1 : Form
    {

        private double ertek1;

        private double ertek2;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /**
         * INPUT HANDLER funkciók
         * numerikus gombok
         */

        private void Button1_Click(object sender, EventArgs e)
        {
            this.addTextInputString((String) "1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.addTextInputString((String)"2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.addTextInputString((String)"3");
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            this.addTextInputString((String)"4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.addTextInputString((String)"5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.addTextInputString((String)"6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.addTextInputString((String)"7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.addTextInputString((String)"8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.addTextInputString((String)"9");
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            this.addTextInputString((String)"0");
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            this.addTextInputString((String)".");
        }


        /**
         * 
         * MŰVELET GOMBOK
         * 
         * 
         * */


        private 



        private void Button4_Click(object sender, EventArgs e)
        {

        }
        
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {

        }

        private void Button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.Width = 1000;
                textBox1.Width = 960;
            }
            else
            {
                this.Width = 359;
                textBox1.Width = 320;
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        protected void addTextInputString(String inputChar)
        {
            textBox1.Text = Form1Controller.getTextBoxTextByInput(textBox1.Text, inputChar);
        }
    }
}
