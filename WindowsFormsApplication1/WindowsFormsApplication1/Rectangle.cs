using System;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Rectangle : Shape
    {
        public Rectangle()
        {
            countofdots = 2;
        }
        public override void Draw(InfoShape reactangle, Graphics g)
        {
            Point StartPoint = reactangle.ListOfPoints[0];
            Point FinishPoint = reactangle.ListOfPoints[1];
            int Width = Math.Abs(StartPoint.X - FinishPoint.X);
            int Height = Math.Abs(StartPoint.Y - FinishPoint.Y);

            if (StartPoint.X < FinishPoint.X)
            {
                if (StartPoint.Y < FinishPoint.Y)
                    g.DrawRectangle(new Pen(Color.Black), StartPoint.X, StartPoint.Y, Width, Height);
                else
                    g.DrawRectangle(new Pen(Color.Black), StartPoint.X, FinishPoint.Y, Width, Height);
            }
            else
            {
                if (FinishPoint.Y < StartPoint.Y)
                    g.DrawRectangle(new Pen(Color.Black), FinishPoint.X, FinishPoint.Y, Width, Height);
                else
                    g.DrawRectangle(new Pen(Color.Black), FinishPoint.X, StartPoint.Y, Width, Height);
            }
        }
    }
}