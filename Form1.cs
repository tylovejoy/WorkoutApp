using System;
using System.Drawing;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {

        int TimeLeft;





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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TimeLeft > 0)
            {
                TimeLeft--;
                textBox1.Text = ConvertSecondsToMinutes(TimeLeft);
            }
            else
            {
                textBox1.Text = "0:00";
                timer1.Stop();
                FlashTimer();



            }
        }

        private void FlashTimer()
        {
            while (true)
            {
                textBox1.BackColor = Color.Red;
                wait(500);
                textBox1.BackColor = Color.White;
                wait(500);
            }
            


        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
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
            textBox1.BackColor = Color.White;
            timer1.Interval = 1000;
            TimeLeft = ConvertTimerToSeconds(textBox1.Text);
            timer1.Start();
        }

        private string ConvertSecondsToMinutes(int timerSeconds)
        {
            int minutes = timerSeconds / 60;
            int seconds = timerSeconds % 60;

            string seconds_s;
            if (seconds < 10)
            {
                seconds_s = "0" + seconds;
            } else
            {
                seconds_s = seconds.ToString();
            }

            return minutes.ToString() + ":" + seconds_s;

        }

        private int ConvertTimerToSeconds(string timerString)
        {
            int seconds = 0;
            int minutes = 0;
            int res;
            string[] values = timerString.Split(':');
            if (values.Length == 2)
            {
                minutes = int.Parse(values[0]);
                seconds = int.Parse(values[1]);
                res = minutes * 60 + seconds;
            } else
            {
                seconds = int.Parse(values[0]);
                res = seconds;
            }
            return res;  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            timer1.Stop();
            textBox1.Text = "2:00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}