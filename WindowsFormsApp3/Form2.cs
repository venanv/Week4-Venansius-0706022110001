using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    { 
        string[,] array;
        int count = 0;
        public Form2(string[,] data)
        {
            InitializeComponent();
            array = data;
            textBox1.Text = data[0, 0];
            textBox2.Text = data[1, 0];
            textBox3.Text = data[2, 0];
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (count == 0)
            {
                MessageBox.Show("Error");
            }

            else
            {
                count--;
                textBox1.Text = array[0, count];
                textBox2.Text = array[1, count];
                textBox3.Text = array[2, count];
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (count == 9)
            {
                MessageBox.Show("Error");
            }

            else
            {
                count++;
                textBox1.Text = array[0, count];
                textBox2.Text = array[1, count];
                textBox3.Text = array[2, count];
            }
        }
    }
}
