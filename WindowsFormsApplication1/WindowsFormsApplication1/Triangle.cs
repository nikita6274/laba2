using System.Collections.Generic;
using System.Drawing;


namespace WindowsFormsApplication1
{

    class Triangle : Shape
    {
        public Triangle()
        {
            countofdots = 3;
        }

        public override void Draw(InfoShape triangle, Graphics g)
        {
            g.DrawPolygon(new Pen(Color.Black), triangle.ListOfPoints.ToArray());
        }
    }
}
