using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ball10._7._19
{
    public partial class Form1 : Form
    {
        int numberOfClicks = 0;

        int points = 0;

        public Form1()
        {
            InitializeComponent();  
        }
       
        private void DoWork(PictureBox picture)
        {
            int dy1 = 1;

            int dx1 = 1;

            while (true)

            {
                Action action = () => { picture.Location = new Point(picture.Location.X + dx1, picture.Location.Y + dy1); };

                picture.BeginInvoke(action);

                if (picture.Location.X <= 0)
                    dx1 = 1;
                if (picture.Location.Y <= 0)
                    dy1 = 1;
                if (picture.Location.X >= this.Width - picture.Width)
                    dx1 = -1;
                if (picture.Location.Y >= this.Height - picture.Height)
                    dy1 = -1;
                
                Thread.Sleep(10);

            }
      
        }

        private void button1_Click(object sender, EventArgs e)
        {

           numberOfClicks = numberOfClicks + 1;

            if (numberOfClicks ==1)
            {
               Task.Run(() =>
                {
                    DoWork(pictureBox1);
                });
            }
            else if(numberOfClicks==2)
            {
                pictureBox2.Visible = true;

                Task.Run(() =>
                {
                    DoWork(pictureBox2);
                });
            }
            else if(numberOfClicks==3)
            {
                pictureBox3.Visible = true;

                Task.Run(() =>
                {
                    DoWork(pictureBox3);
                });
            }
            else if (numberOfClicks == 4)
            {
                pictureBox4.Visible = true;

                Task.Run(() =>
                {
                    DoWork(pictureBox4);
                });
            }
            else if (numberOfClicks == 5)
            {
                pictureBox5.Visible = true;

                Task.Run(() =>
                {
                    DoWork(pictureBox5);
                });
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

            points = points+1;

            if(points==5)
            {
                MessageBox.Show("You won!!!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;

            points = points+1;

            if (points == 5)
            {
                MessageBox.Show("You won!!!");
            }
        }

       

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;

            points = points + 1;

            if (points == 5)
            {
                MessageBox.Show("You won!!!");
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;

            points = points + 1;

            if (points == 5)
            {
                MessageBox.Show("You won!!!");
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;

            points = points + 1;

            if (points == 5)
            {
                MessageBox.Show("You won!!!");
            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;

            points = points + 1;

            if (points == 5)
            {
                MessageBox.Show("You won!!!");
            }
        }
    }
}
