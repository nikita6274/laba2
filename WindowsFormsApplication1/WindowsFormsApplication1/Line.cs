using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Line : Shape
    {
        public Line()
        {
            countofdots = 2;
        }

        public override void Draw(InfoShape line, Graphics g)
        {
            Point StartPoint = line.ListOfPoints[0];
            Point FinishPoint = line.ListOfPoints[1];

            g.DrawLine(new Pen(Color.Black), StartPoint, FinishPoint);
        }
    }
}
