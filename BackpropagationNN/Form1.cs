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

namespace BackpropagationNN
{
    public partial class Form1 : Form
    {
        NeuralNet nn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void create_bpnn_Click(object sender, EventArgs e)
        {
            // 2 input OR
            //nn = new NeuralNet(2,100,1); // input, hidden, output
            // 4 input AND
            nn = new NeuralNet(4, 100, 1);

        }

        private void train_nn_Click(object sender, EventArgs e)
        {

            // 4 input AND
            for (int i = 0; i < 100; i++)
            {
                // 0, 0, 0, 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // 0, 0, 0, 1
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // 0, 0, 1, 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // 0, 0, 1, 1
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // ---

                // 0, 1, 0, 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // 0, 1, 0, 1
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // 0, 1, 1, 0
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // 0, 1, 1, 1
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //---

                // 1, 0, 0, 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // 1, 0, 0, 1
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // 1, 0, 1, 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // 1, 0, 1, 1
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // ---

                // 1, 1, 0, 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // 1, 1, 0, 1
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // 1, 1, 1, 0
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                // 1, 1, 1, 1
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

            }


            // 2 input OR
            //for (int x = 0; x < 100; x++)
            //{

            //    nn.setInputs(0, 0.0);
            //    nn.setInputs(1, 0.0);
            //    nn.setDesiredOutput(0, 0.0);
            //    nn.learn();

            //    nn.setInputs(0, 0.0);
            //    nn.setInputs(1, 1.0);
            //    nn.setDesiredOutput(0, 1.0);
            //    nn.learn();

            //    nn.setInputs(0, 1.0);
            //    nn.setInputs(1, 0.0);
            //    nn.setDesiredOutput(0, 1.0);
            //    nn.learn();

            //    nn.setInputs(0, 1.0);
            //    nn.setInputs(1, 1.0);
            //    nn.setDesiredOutput(0, 1.0);
            //    nn.learn();

            //}

        }

        private void test_Click(object sender, EventArgs e)
        {

            // 4 input AND

            nn.setInputs(0, Convert.ToDouble(first_input.Text));
            nn.setInputs(1, Convert.ToDouble(second_input.Text));
            nn.setInputs(2, Convert.ToDouble(third_input.Text));
            nn.setInputs(3, Convert.ToDouble(fourth_input.Text));

            nn.run();

            output_box.Text = "" + nn.getOuputData(0);

            // 2 input OR
            //nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            //nn.setInputs(1, Convert.ToDouble(textBox2.Text));

            //nn.run();
            //textBox3.Text = "" + nn.getOuputData(0);
        }
    }
}
