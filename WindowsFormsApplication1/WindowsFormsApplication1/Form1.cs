using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        private Shape AdditionalShape;
        public List<InfoShape> ListOfShape = new List<InfoShape>();
        private Dictionary<string, Factory> DictionaryOfShape = new Dictionary<string, Factory>();
        public List<List<Point>> AdditionalListOfNewPoints = new List<List<Point>>();
        public Graphics g;

        public MainForm()
        {
            InitializeComponent();
        }
        private void Check(int CountRequiredDots,Point AdditionalPoint)
        {
            int Value = AdditionalListOfNewPoints.Count - 1;

            if (AdditionalListOfNewPoints[Value].Count == CountRequiredDots)
            {
           
                ListOfShape.Add(new InfoShape { Shape = AdditionalShape, ListOfPoints = AdditionalListOfNewPoints[Value] });

                AdditionalShape.Draw(ListOfShape[ListOfShape.Count - 1], g);
                AdditionalListOfNewPoints.Add(new List<Point>());
            }
        }

        private void CreateShape(Factory shape)
        {
            AdditionalShape = shape.GetFigure();
            AdditionalListOfNewPoints.Add(new List<Point>());
        }

        private void OnClick(object sender, EventArgs e)
        {
            CreateShape(DictionaryOfShape[((Button)sender).Text]); 
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Point AdditionalPoint = e.Location;

            AdditionalListOfNewPoints[AdditionalListOfNewPoints.Count-1].Add(AdditionalPoint);

            textBox1.Text = AdditionalListOfNewPoints.Count.ToString();
            int Value = AdditionalShape.CountsDots;

            Check(Value, AdditionalPoint);
            
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            OnClick(sender, e);
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            PictureBox.Image = null;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            g = PictureBox.CreateGraphics();
            

            DictionaryOfShape.Add("Rectangle", new RectangleFactory());
            DictionaryOfShape.Add("Square", new SquareFactory());
            DictionaryOfShape.Add("Ellipse", new EllipseFactory());
            DictionaryOfShape.Add("Circle", new CircleFactory());
            DictionaryOfShape.Add("Line", new LineFactory());
            DictionaryOfShape.Add("Triangle", new TriangleFactory());
            CreateShape(DictionaryOfShape["Line"]);
        }

        private void Square_Click(object sender, EventArgs e)
        {
            OnClick(sender, e);
        }

       

        private void Ellipse_Click(object sender, EventArgs e)
        {
            OnClick(sender, e);
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            OnClick(sender, e);
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            OnClick(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
