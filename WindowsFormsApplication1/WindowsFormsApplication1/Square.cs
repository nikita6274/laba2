using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Square : Rectangle
    {
        public Square()
        {
            countofdots = 2;
        }

        public override void Draw(InfoShape square, Graphics g)
        {
            Point StartPoint = square.ListOfPoints[0];
            Point FinishPoint = square.ListOfPoints[1];

            if (StartPoint.X < FinishPoint.X)
            {
                if (StartPoint.Y < FinishPoint.Y)
                    g.DrawRectangle(new Pen(Color.Black), StartPoint.X, StartPoint.Y, FinishPoint.Y - StartPoint.Y, FinishPoint.Y - StartPoint.Y);
                else
                    g.DrawRectangle(new Pen(Color.Black), StartPoint.X, FinishPoint.Y, FinishPoint.X - StartPoint.X, FinishPoint.X - StartPoint.X);
            }
            else
            {
                if (FinishPoint.Y < StartPoint.Y)
                    g.DrawRectangle(new Pen(Color.Black), FinishPoint.X, FinishPoint.Y, StartPoint.Y - FinishPoint.Y, StartPoint.Y - FinishPoint.Y);
                else
                    g.DrawRectangle(new Pen(Color.Black), FinishPoint.X, StartPoint.Y, FinishPoint.Y - StartPoint.Y, FinishPoint.Y - StartPoint.Y);
            }
        }
    }
}
