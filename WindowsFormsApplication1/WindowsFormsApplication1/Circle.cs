using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Circle : Ellipse
    {
        public Circle()
        {
            countofdots = 2;
        }

        public override void Draw(InfoShape circle, Graphics g)
        {
            Point StartPoint = circle.ListOfPoints[0];
            Point FinishPoint = circle.ListOfPoints[1];

            if (StartPoint.X < FinishPoint.X)
            {
                if (StartPoint.Y < FinishPoint.Y)
                    g.DrawEllipse(new Pen(Color.Black), StartPoint.X, StartPoint.Y, FinishPoint.Y - StartPoint.Y, FinishPoint.Y - StartPoint.Y);
                else
                    g.DrawEllipse(new Pen(Color.Black), StartPoint.X, FinishPoint.Y, FinishPoint.X - StartPoint.X, FinishPoint.X - StartPoint.X);
            }
            else
            {
                if (FinishPoint.Y < StartPoint.Y)
                    g.DrawEllipse(new Pen(Color.Black), FinishPoint.X, FinishPoint.Y, StartPoint.Y - FinishPoint.Y, StartPoint.Y - FinishPoint.Y);
                else
                    g.DrawEllipse(new Pen(Color.Black), FinishPoint.X, StartPoint.Y, FinishPoint.Y - StartPoint.Y, FinishPoint.Y - StartPoint.Y);
            }
        }
    }
}