using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_Multiple_Circles
{
    public partial class Form1 : Form
    {
        Graphics drawing;
        public Form1()
        {
            InitializeComponent();
            drawing = this.CreateGraphics();
        }

        //---- paint event
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           /* Graphics drawing = e.Graphics;
            Pen myPen = new Pen(Color.Black , 1);
            Brush myBrush = new SolidBrush(Color.Black);

            //xy-axes:
            /*drawing.DrawLine(myPen, 250, 200, 450, 200);
            drawing.DrawLine(myPen, 250, 200, 250, 50);
            drawing.DrawLine(myPen, 250, 200, 50, 200);
            drawing.DrawLine(myPen, 250, 200, 250, 450);*/
            
            //circles: 
            //drawing.DrawEllipse(myPen, 250,175, 150,150);
            //drawing.DrawEllipse(myPen, 175,175, 150,150); //<<======== center
            //drawing.DrawEllipse(myPen, 175, 250, 150, 150);
            //drawing.DrawEllipse(myPen, 100 , 175, 150, 150);
            //drawing.DrawEllipse(myPen, 175 , 100, 150, 150);

        }//end paint event


        //When you click the create button: 
        private void button1_Click(object sender, EventArgs e)
        {
            drawing.Clear(Color.White);
            Pen myPen = new Pen(Color.Black , 2);
            int iterations = Convert.ToInt32(numberOfCirclesBox.Text);        
            
            //choosing the color: 
            if (colorComboBox.SelectedIndex == 0)
            {
                myPen.Color = Color.Black;
            }
            else if (colorComboBox.SelectedIndex == 1)
            {
                myPen.Color = Color.Red;
            }
            else if (colorComboBox.SelectedIndex == 2)
            {
                myPen.Color = Color.Blue;
            }
            else if (colorComboBox.SelectedIndex == 3)
            {
                myPen.Color = Color.Green;
            }
            else if (colorComboBox.SelectedIndex == 4)
            {
                myPen.Color = Color.Purple;
            }

            //set all the values: 
            int radius = 75;
            double theta = 0.0;
            double Pi = 3.14;
            double RX = 175 + radius * Math.Sin(theta);  //175
            double RY = 125 + radius * Math.Cos(theta);  //200
                                                         
            //for loop to display the circles: 
            for (int i = 0; i < iterations; i++)
            {
                drawing.DrawEllipse(myPen, (float)RX, (float)RY, radius * 2, radius * 2);              

                theta = theta + (Pi / 180) * (360 / iterations);
                RX = 175 + radius * Math.Sin(theta);
                RY = 125 + radius * Math.Cos(theta);

            }//end for loop
        }//end clicking event
    }//end class
}
