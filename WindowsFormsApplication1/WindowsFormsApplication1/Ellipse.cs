using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Ellipse : Shape
    {
        public Ellipse()
        {
            countofdots = 2;
        }

        public override void Draw(InfoShape ellipse, Graphics g)
        {
            Point StartPoint = ellipse.ListOfPoints[0];
            Point FinishPoint = ellipse.ListOfPoints[1];

            g.DrawEllipse(new Pen(Color.Black), StartPoint.X, StartPoint.Y, FinishPoint.X - StartPoint.X, FinishPoint.Y - StartPoint.Y);
        }
    }
}
