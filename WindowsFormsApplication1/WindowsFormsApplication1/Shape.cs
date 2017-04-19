using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApplication1
{
    
    public abstract class Shape
    {

        protected int countofdots;
        public int CountsDots { get { return countofdots; } private set { countofdots = value; } }
        
        public virtual void Draw(InfoShape shape, Graphics g) { }
        
    }
}
