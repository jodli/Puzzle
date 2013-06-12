using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Puzzles
{
    class PuzzlePiece : TransParentLib.UserControlTP
    {
        public PuzzlePiece()
            : base()
        {
            this.points = new Point[5];
            this.color = Color.Black;
            this.inPos = true;
            base.Paint += PuzzlePiece_Paint;
        }

        void PuzzlePiece_Paint(object sender, PaintEventArgs e)
        {
            if (e == null)
            {
                return;
            }

            // draw clipped image
            e.Graphics.Clip = this.rgClip;
            e.Graphics.DrawImage(this.Image, 0, 0);
            e.Graphics.ResetClip();

            // draw border around puzzlepiece
            e.Graphics.DrawPath(new Pen(this.BorderColor, 2f), gpClip);
        }

        // puzzlepiece in final position
        private bool inPos;

        public bool inPosition
        {
            get { return this.inPos; }
            set { this.inPos = value; }
        }

        // moved image to static reference class
        //private Image img; 

        public Image Image
        {
            get
            {
                return Reference.Image;
                //return this.img;
            }
            set
            {
                Reference.Image = value;
                // set size of control to image size
                this.Size = value.Size;
                // (re-) init PointList
                initPoints();
            }
        }

        private void initPoints()
        {
            // get image boundaries
            GraphicsUnit unit = GraphicsUnit.Pixel;
            Rectangle rectImg = Rectangle.Round(this.Image.GetBounds(ref unit));

            // init pointlist -> clockwise
            // top left corner
            points[0] = new Point(rectImg.Left, rectImg.Top);
            // start point == end point
            points[4] = points[0];
            // top right corner
            points[1] = new Point(rectImg.Right - 1, rectImg.Top);
            // bottom right corner
            points[2] = new Point(rectImg.Right - 1, rectImg.Bottom - 1);
            // bottom left corner
            points[3] = new Point(rectImg.Left, rectImg.Bottom - 1);

            this.Refresh();
        }

        // pointlist for polygon
        private Point[] points;

        public Point[] PointList
        {
            get { return (Point[])this.points.Clone(); }
        }

        public GraphicsPath gpClip
        {
            get
            {
                // recalculate graphicsclip when neede
                GraphicsPath gp = new GraphicsPath();
                gp.AddPolygon(this.PointList);
                return gp;
            }
        }

        public Region rgClip
        {
            get
            {
                // recalculate and set region when needed
                this.Region = new Region(this.gpClip);
                return this.Region;
            }
        }

        // border color for puzzlepieces
        private Color color;

        public Color BorderColor
        {
            get { return color; }
            set
            {
                color = value;
                this.Refresh();
            }
        }

        // calculate area when needed
        public double Area
        {
            get { return this.calcArea(this.PointList); }
        }

        // is (mousedown) point inside graphicsclip aka puzzlepiece
        public bool isInside(Point pt)
        {
            if (this.gpClip.IsVisible(pt))
            {
                return true;
            }
            return false;
        }

        // calculate area of polygon
        private double calcArea(Point[] ptList)
        {
            int i, j;
            double area = 0;

            // start algorithm -> iterate over point array
            for (i = 0; i < ptList.Length; i++)
            {
                j = (i + 1) % ptList.Length;

                area += ptList[i].X * ptList[j].Y;
                area -= ptList[j].X * ptList[i].Y;
            }

            area /= 2;
            // return absolute area, should only be negative when points are defined counter-clockwise
            return (area < 0 ? -area : area);
        }

        public bool Split(out PuzzlePiece pp1, out PuzzlePiece pp2)
        {
            // get random seed based on current time
            Random random = new Random(DateTime.Now.Millisecond);

            pp1 = new PuzzlePiece();
            pp1.Bounds = this.Bounds;
            //pp1.Image = this.Image;

            pp2 = new PuzzlePiece();
            pp2.Bounds = this.Bounds;
            //pp2.Image = this.Image;

            ArrayList list1 = new ArrayList();
            ArrayList list2 = new ArrayList();
            int line1, line2;

            // try 10 times to split this puzzlepiece
            for (int i = 0; i < 10; i++)
            {
                // clear polygon lists
                list1.Clear();
                list2.Clear();

                // get random lines
                do
                {
                    line1 = random.Next(this.points.Length - 1);
                    line2 = random.Next(this.points.Length - 1);
                } while (line1 >= line2);

                // get random points on lines
                double offset;
                offset = random.NextDouble();
                Point point1 = createPointOnLine(this.points[line1], this.points[line1 + 1], offset);
                offset = random.NextDouble();
                Point point2 = createPointOnLine(this.points[line2], this.points[line2 + 1], offset);

                // add points clockwise to list1
                list1.Add(point1);
                for (int j = line1 + 1; j <= line2; j++)
                {
                    list1.Add(this.points[j]);
                }
                list1.Add(point2);
                // start point == end point
                list1.Add(point1);
                // add points to puzzlepiece and recalculate area
                pp1.points = (Point[])list1.ToArray(typeof(Point));
                //pp1.area = pp1.calcArea(pp1.points);

                // add points clockwise to list2
                list2.Add(point2);
                for (int j = line2 + 1; j < line1 + (this.points.Length); j++)
                {
                    list2.Add(this.points[j % (this.points.Length - 1)]);
                }
                list2.Add(point1);
                // start point == end point
                list2.Add(point2);
                // add points to puzzlepiece and recalculate area
                pp2.points = (Point[])list2.ToArray(typeof(Point));
                //pp2.area = pp2.calcArea(pp2.points);

                if (!(evalPuzzlePiece(pp1) || evalPuzzlePiece(pp2)))
                {
                    // polygon splitting possible
                    return true;
                }
            }
            // polygon splitting impossible after 10 tries
            pp1 = null;
            pp2 = null;
            return false;
        }

        // [WIP] recombine puzzlepieces to get rid of borders
        public PuzzlePiece Combine(PuzzlePiece pp)
        {
            ArrayList list = new ArrayList();
            int i = -1, j = 0;

            ArrayList points1 = new ArrayList(this.PointList);
            ArrayList points2 = new ArrayList(pp.PointList);

            list.AddRange(points1);
            foreach (Point point in points2)
            {
                i = list.IndexOf(point);
                if (i != -1)
                {
                    break;
                }
            }
            list.InsertRange(i, points2);

            PuzzlePiece newPp = new PuzzlePiece();
            newPp.Location = this.Location;
            newPp.Image = this.Image;
            newPp.points = (Point[])list.ToArray(typeof(Point));
            return newPp;
        }

        // check if splitted new puzzlepiece is big enough
        private bool evalPuzzlePiece(PuzzlePiece pp)
        {
            bool flag = false;

            // minimum pixel area
            if (pp.Area < 20f)
            {
                flag = true;
            }

            // area between 30% and 70% of original polygon; original == (pp1 + pp2)
            if (pp.Area < this.Area * .3f || pp.Area > this.Area * .7f)
            {
                flag = true;
            }

            // width greater 8 pixel
            if (calcWidth(pp) < 8f)
            {
                flag = true;
            }

            return flag;
        }

        // calculate a point on a line
        private Point createPointOnLine(Point p1, Point p2, double offset)
        {
            if (p1 == p2)
            {
                return p1;
            }
            return new Point((int)(p1.X + offset * (p2.X - p1.X)), (int)(p1.Y + offset * (p2.Y - p1.Y)));
        }

        // calculate width of puzzlepiece
        private double calcWidth(PuzzlePiece pp)
        {
            double width = 0f;
            double a = 0, b = 0, c = 0;
            double mid1 = 0, mid2 = 0;

            // calculate centroid of polygon
            for (int i = 0; i < pp.PointList.Length - 1; i++)
            {
                mid1 += pp.PointList[i].X;
                mid2 += pp.PointList[i].Y;
            }

            mid1 /= (pp.PointList.Length - 1);
            mid2 /= (pp.PointList.Length - 1);

            // calculate a, b, c and width^2 according to equation
            for (int i = 0; i < pp.PointList.Length - 1; i++)
            {
                a += (Math.Pow((pp.PointList[i].X - mid1), 2));
                b += ((pp.PointList[i].X - mid1) * (pp.PointList[i].Y - mid2));
                c += (Math.Pow((pp.PointList[i].Y - mid2), 2));
            }
            width = (2f / (pp.PointList.Length - 1)) * (a + c - Math.Sqrt(Math.Pow((a + c), 2) - 4f * ((a * c) - Math.Pow(b, 2))));

            return Math.Sqrt(width);
        }

        // calculate distance between two puzzlepieces
        public double Distance(PuzzlePiece pp2)
        {
            bool flag = false;

            // have a point in common?
            foreach (Point point1 in this.PointList)
            {
                foreach (Point point2 in pp2.PointList)
                {
                    if (point1 == point2)
                    {
                        flag = true;
                    }
                }
            }

            // distance between two points (left side pp2 - left side this) and (top side pp2 - top side this)
            if (flag)
            {
                return Math.Sqrt((Math.Pow(pp2.Left - this.Left, 2) + Math.Pow(pp2.Top - this.Top, 2)));
            }
            // no line in common
            else
            {
                return double.MaxValue;
            }
        }
    }
}
