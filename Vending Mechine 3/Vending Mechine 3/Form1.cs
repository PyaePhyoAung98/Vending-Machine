using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vending_Mechine_3
{
    public partial class Form1 : Form
    {
        private Boolean cocaButtonWasClicked = false;
        private Boolean pepsiButtonWasClicked = false;
        private Boolean monsterButtonWasClicked = false;
        public Form1()
        {
            InitializeComponent();
            cocaSlide.Visible = false;
            pepsiSlide.Visible = false;
            monsterSlide.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sound sys
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Acer\\Desktop\\New\\slow.wav";
            s.Play();

            //priceChecking 

            int cocaPrice = int.Parse(cocaprice.Text);
            int pepsiPrice = int.Parse(pepsiprice.Text);
            int monsterPrice = int.Parse(monsterprice.Text);

            int textBox = int.Parse(textBox1.Text);

            string price = textBox1.Text;

            //cocaPrice check and output

            if (cocaButtonWasClicked == true)
            {
                if (textBox >= cocaPrice)
                {
                    int aa = textBox - cocaPrice;
                    textBox1.Text = aa.ToString();
                    count = aa;
                    cocaSlide.Visible = true;
                    pepsiSlide.Visible = false;
                    monsterSlide.Visible = false;
                }


            }

            //pepsiPrice Check and output

            if (pepsiButtonWasClicked == true)
            {

                if (textBox >= pepsiPrice)
                {
                    int aa = textBox - pepsiPrice;
                    textBox1.Text = aa.ToString();
                    count = aa;
                    pepsiSlide.Visible = true;
                    monsterSlide.Visible = false;
                    cocaSlide.Visible = false;
                }


            }

            //monsterPriceCheck&Output
            if (monsterButtonWasClicked == true)
            {


                if (textBox >= monsterPrice)
                {
                    int aa = textBox - monsterPrice;
                    textBox1.Text = aa.ToString();
                    count = aa;
                    monsterSlide.Visible = true;
                    pepsiSlide.Visible = false;
                    cocaSlide.Visible = false;
                }

            }


        }

        private void coca1_Click(object sender, EventArgs e)
        {


            button1.Enabled = true;
            cocaButtonWasClicked = true;



        }

        private void coca2_Click(object sender, EventArgs e)
        {

            button1.Enabled = true;
            cocaButtonWasClicked = true;


        }

        private void coca3_Click(object sender, EventArgs e)
        {

            button1.Enabled = true;
            cocaButtonWasClicked = true;

        }

        private void pepsi1_Click(object sender, EventArgs e)
        {
            int textBox = int.Parse(textBox1.Text);

            button1.Enabled = true;
            pepsiButtonWasClicked = true;
            if (textBox == 0 || textBox < 10)
            {
                button1.Enabled = false;
            }
        }

        private void pepsi2_Click(object sender, EventArgs e)
        {
            int textBox = int.Parse(textBox1.Text);
            button1.Enabled = true;
            pepsiButtonWasClicked = true;
            if (textBox == 0 || textBox < 10)
            {
                button1.Enabled = false;
            }

        }

        private void pepsi3_Click(object sender, EventArgs e)
        {
            int textBox = int.Parse(textBox1.Text);
            button1.Enabled = true;
            pepsiButtonWasClicked = true;
            if (textBox == 0 || textBox < 10)
            {
                button1.Enabled = false;
            }
        }

        private void monster1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            monsterButtonWasClicked = true;
        }

        private void monster2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            monsterButtonWasClicked = true;
        }

        private void monster3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            monsterButtonWasClicked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int cocaPrice = int.Parse(cocaprice.Text);
            int pepsiPrice = int.Parse(pepsiprice.Text);
            int monsterPrice = int.Parse(monsterprice.Text);
            int textBox = int.Parse(textBox1.Text);

            if (textBox == 5)
            {
                textBox1.Text = "0" + textBox;
            }
            if (textBox >= cocaPrice)
            {
                coca1.Enabled = true;
                coca2.Enabled = true;
                coca3.Enabled = true;

            }
            if (textBox >= pepsiPrice)
            {
                pepsi1.Enabled = true;
                pepsi2.Enabled = true;
                pepsi3.Enabled = true;
            }
            if (textBox >= monsterPrice)
            {
                monster1.Enabled = true;
                monster2.Enabled = true;
                monster3.Enabled = true;
            }
        }
        public int count;

        private void btn_5_Click(object sender, EventArgs e)
        {
            count += 5;
            textBox1.Text = count.ToString();
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            count += 10;
            textBox1.Text = count.ToString();
        }

        private void cocaSlide_Click(object sender, EventArgs e)
        {
            cocaSlide.Visible = false;
            button1.Enabled = false;
        }

        private void pepsiSlide_Click(object sender, EventArgs e)
        {
            pepsiSlide.Visible = false;

            button1.Enabled = false;
        }

        private void monsterSlide_Click(object sender, EventArgs e)
        {
            monsterSlide.Visible = false;

            button1.Enabled = false;
        }

        private void admin_Sitting_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            Form1 mainform = new Form1();
            mainform.Close();
            
        }
    }
}