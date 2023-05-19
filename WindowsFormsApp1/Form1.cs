using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public partial class ЛабораторнаяРабота4 : Form

        {
          
            Rectangle Rectangle = new Rectangle(10, 10, 200, 100);

            Rectangle Circle = new Rectangle(220, 10, 150, 150);

            Rectangle Square = new Rectangle(380, 10, 150, 150);


            private int LastClicked;
            private bool RectangleClicked;
            private int RectangleX;
            private int RectangleY;
            private object CircleX;
            private object CircleY;
            private object SquareX;
            private object SquareY;

            private void Label1_Click(object sender, EventArgs e, Button label1, Button label3)
            {

                if ((label1.Location.X < Square.X + Square.Width) && (label1.Location.X > Square.X))
                {
                    if ((label1.Location.Y < Square.Y + Square.Height) && (label1.Location.Y > Square.Y))
                    {

                        label3.Text = "Синий квадрат";

                    }

                }

            }

            private void Label2_Click(object sender, EventArgs e, Button label1, Button label2)
            {

                int X, Y, dX, dY;

                int LastClicked = 0;

                if (LastClicked == 2)

                {

                    if ((label2.Location.X < Circle.X + Circle.Width) && (label2.Location.X > Circle.X))

                    {

                        if ((label2.Location.Y < Circle.Y + Circle.Height) && (label2.Location.Y > Circle.Y))

                        {

                            X = Circle.X;

                            Y = Circle.Y;

                            dX = Circle.X;

                            dY = Circle.Y;
                            CircleX = SquareX;

                            CircleY = SquareY;

                            CircleX = SquareX;

                            CircleY = SquareY;
                            Square.X = X;

                            Square.Y = Y;

                            SquareX = dX;

                            SquareY = dY;

                        }

                    }

                }
              
            }
            private void PictureBox1_Click(object sender, PaintEventArgs e, PictureBox pictureBox)

            {

                e.Graphics.FillEllipse(Brushes.Red, Circle);

                e.Graphics.FillRectangle(Brushes.Blue, Square);

                e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);

                int X = 0;
                int Y = 0;


                if ((X < Rectangle.X + Rectangle.Width) && (X > Rectangle.X))

                {

                    if ((Y < Rectangle.Y + Rectangle.Height) && (Y > Rectangle.Y))

                    {

                        RectangleClicked = true;
                        RectangleX = X - Rectangle.X;

                        RectangleY = Y - Rectangle.Y;
                    }

                }

                pictureBox.Invalidate();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
