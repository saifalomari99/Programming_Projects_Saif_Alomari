using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Question_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //paint event:
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //---------------------------- set the tools ----------------------------
            Graphics drawing = e.Graphics;
            Pen myPen = new Pen(Color.Black,3);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush whiteBrush = new SolidBrush(Color.White);

            //---------------------------- set and save the locations: --------------
            //The big circle:
            drawing.DrawEllipse(myPen, 0,0, 400,400);
            //drawArc         start point, diameter, strarting point
            drawing.DrawArc(myPen, 100, 0, 200, 200, 90, -180);
            drawing.DrawArc(myPen, 100, 200, 200, 200, -90, -180);
            //small circles:
            drawing.DrawEllipse(myPen, 175, 80, 50,50);
            drawing.DrawEllipse(myPen, 175, 270, 50, 50);


            //---------------------------- filling the colors -----------------------
            Rectangle BigCircle = new Rectangle(0, 0, 400, 400);
            
            //fill the right half of the circle with black color:
            drawing.FillPie(blackBrush, BigCircle, -90, -180);
            //fill the left side with white:
            drawing.FillPie(whiteBrush, BigCircle, 90, -180);

            //fill the upper arc with black color:
            drawing.FillEllipse(blackBrush, 100, 0, 200, 200);
            //fill the down arc with white color:
            drawing.FillEllipse(whiteBrush, 100, 200, 200, 200);

            //filling the upper circle:
            drawing.FillEllipse(whiteBrush, 175, 80, 50, 50);
            //filling the down circle
            drawing.FillEllipse(blackBrush, 175, 270, 50, 50);
            


        }//end drawing event
    }
}
