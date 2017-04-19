using System.Collections.Generic;
using System.Drawing;


namespace WindowsFormsApplication1
{
    public class InfoShape
    {
        private Shape figure;
        private List<Point> dots;
        public Shape Shape { get { return figure; } set { figure = value; } }
        public List<Point> ListOfPoints { get { return dots; } set { dots = value; } }
    }
}
