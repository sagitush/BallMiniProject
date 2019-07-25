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
        Random r = new Random(); 
       
        public Form1()
        {
            InitializeComponent();  
        }
       
        private async void button1_Click(object sender, EventArgs e)
        {
            int pointX = r.Next(1, ClientSize.Width);

            int pointY = r.Next(1, ClientSize.Height);

            PictureBox picture = new PictureBox { Name = "pictureBox", Location = new Point(pointX, pointY),Image= Image.FromFile(@"C:\temp\sagit\blue.jpg")   };

            picture.SizeMode = PictureBoxSizeMode.Zoom;

            this.Controls.Add(picture);

            int dy1 = 1;

            int dx1 = 1;

            while (true)
            {
                 picture.Location = new Point(picture.Location.X + dx1, picture.Location.Y + dy1); 
      
                if (picture.Location.X <= 0)
                    dx1 = 1;
                if (picture.Location.Y <= 0)
                    dy1 = 1;
                if (picture.Location.X >= this.Width - picture.Width)
                    dx1 = -1;
                if (picture.Location.Y >= this.Height - picture.Height)
                    dy1 = -1;
               await Task.Run(()=> Thread.Sleep(10));
            }
           
        }
    }
}
