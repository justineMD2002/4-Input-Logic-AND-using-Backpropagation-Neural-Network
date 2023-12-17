using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace _4_Input_Logic_AND_using_Backpropagation_Neural_Network
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 44, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 440; i++) {
                supervise();
            }
        }

        public void supervise()
        {
            nn.setInputs(0, 0.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 0.0);
            nn.setInputs(3, 0.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();

            nn.setInputs(0, 0.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 0.0);
            nn.setInputs(3, 1.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();

            nn.setInputs(0, 0.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 0.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();

            nn.setInputs(0, 0.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 1.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();

            nn.setInputs(0, 0.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 0.0);
            nn.setInputs(3, 0.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();

            nn.setInputs(0, 0.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 0.0);
            nn.setInputs(3, 1.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();

            nn.setInputs(0, 0.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 0.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();

            nn.setInputs(0, 0.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 1.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();

            nn.setInputs(0, 1.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 0.0);
            nn.setInputs(3, 0.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();

            nn.setInputs(0, 1.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 0.0);
            nn.setInputs(3, 1.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();

            nn.setInputs(0, 1.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 0.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();

            nn.setInputs(0, 1.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 1.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();

            nn.setInputs(0, 1.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 0.0);
            nn.setInputs(3, 0.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();

            nn.setInputs(0, 1.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 0.0);
            nn.setInputs(3, 1.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();

            nn.setInputs(0, 1.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 0.0);
            nn.setDesiredOutput(0, 0.0);
            nn.learn();

            nn.setInputs(0, 1.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 1.0);
            nn.setDesiredOutput(0, 1.0);
            nn.learn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.setInputs(2, Convert.ToDouble(textBox3.Text));
            nn.setInputs(3, Convert.ToDouble(textBox4.Text));
            nn.run();
            textBox5.Text = "" + nn.getOuputData(0);
        }
    }
}
