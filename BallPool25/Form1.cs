using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BallPool25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            int empty = 0;

            if (textBox1.Text == "")
                empty = empty + 1;

            if (textBox2.Text == "")
                empty = empty + 1;

            if (textBox3.Text == "")
                empty = empty + 1;

            if (RadBallBox.Text == "")
                empty = empty + 1;

            if (NumBallsBox.Text == "")
                empty = empty + 1;

            if (empty != 1)
            {
                MessageBox.Show("Please leave exactly one box empty.");
                return;
            }

            {
                double efficiency = 0.64;


                // number of balls
                if (NumBallsBox.Text == "")
                {
                    double Length = double.Parse(textBox1.Text);
                    double Width = double.Parse(textBox2.Text);
                    double Depth = double.Parse(textBox3.Text);
                    double BallRadius = double.Parse(RadBallBox.Text);

                    double VolumeOfPool = Length * Width * Depth;
                    double VolumeOfBall =
                        (4.0 / 3.0) * Math.PI * Math.Pow(BallRadius, 3);

                    double NumOfBalls =
                        (VolumeOfPool * efficiency) / VolumeOfBall;

                    NumBallsBox.Text = Math.Floor(NumOfBalls).ToString();
                }

                // Ball radius
                else if (RadBallBox.Text == "")
                {
                    double Length = double.Parse(textBox1.Text);
                    double Width = double.Parse(textBox2.Text);
                    double Depth = double.Parse(textBox3.Text);
                    double NumOfBalls = double.Parse(NumBallsBox.Text);

                    double VolumeOfPool = Length * Width * Depth;

                    double VolumeOfBall =
                        (VolumeOfPool * efficiency) / NumOfBalls;

                    double BallRadius =
                        Math.Pow(
                            (3 * VolumeOfBall) / (4 * Math.PI),
                            1.0 / 3.0
                        );

                    RadBallBox.Text = Math.Round(BallRadius, 2).ToString();
                }

                // calculates length
                else if (textBox1.Text == "")
                {
                    double Width = double.Parse(textBox2.Text);
                    double Depth = double.Parse(textBox3.Text);
                    double BallRadius = double.Parse(RadBallBox.Text);
                    double NumOfBalls = double.Parse(NumBallsBox.Text);

                    double VolumeOfBall =
                        (4.0 / 3.0) * Math.PI * Math.Pow(BallRadius, 3);

                    double VolumeOfPool =
                        (NumOfBalls * VolumeOfBall) / efficiency;

                    double Length =
                        VolumeOfPool / (Width * Depth);

                    textBox1.Text = Math.Round(Length, 2).ToString();
                }

                // Calculates Width
                else if (textBox2.Text == "")
                {
                    double Length = double.Parse(textBox1.Text);
                    double Depth = double.Parse(textBox3.Text);
                    double BallRadius = double.Parse(RadBallBox.Text);
                    double NumOfBalls = double.Parse(NumBallsBox.Text);

                    double VolumeOfBall =
                        (4.0 / 3.0) * Math.PI * Math.Pow(BallRadius, 3);

                    double VolumeOfPool =
                        (NumOfBalls * VolumeOfBall) / efficiency;

                    double Width =
                        VolumeOfPool / (Length * Depth);

                    textBox2.Text = Math.Round(Width, 2).ToString();
                }

                // Calculates Depth
                else if (textBox3.Text == "")
                {
                    double Length = double.Parse(textBox1.Text);
                    double Width = double.Parse(textBox2.Text);
                    double BallRadius = double.Parse(RadBallBox.Text);
                    double NumOfBalls = double.Parse(NumBallsBox.Text);

                    double VolumeOfBall =
                        (4.0 / 3.0) * Math.PI * Math.Pow(BallRadius, 3);

                    double VolumeOfPool =
                        (NumOfBalls * VolumeOfBall) / efficiency;

                    double Depth =
                        VolumeOfPool / (Length * Width);

                    textBox3.Text = Math.Round(Depth, 2).ToString();
                }

                // 2 or more boxes are empty
                else
                {
                    MessageBox.Show("Please leave at least one box empty.");
                }
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
