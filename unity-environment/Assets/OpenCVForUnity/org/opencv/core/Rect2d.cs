using System;

namespace OpenCVForUnity
{

    //javadoc:Rect2d_
    [System.Serializable]
    public class Rect2d
    {

        public double x, y, width, height;

        public Rect2d (double x, double y, double width, double height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public Rect2d ()
            : this (0, 0, 0, 0)
        {

        }

        public Rect2d (Point p1, Point p2)
        {
            x = (double)(p1.x < p2.x ? p1.x : p2.x);
            y = (double)(p1.y < p2.y ? p1.y : p2.y);
            width = (double)(p1.x > p2.x ? p1.x : p2.x) - x;
            height = (double)(p1.y > p2.y ? p1.y : p2.y) - y;
        }

        public Rect2d (Point p, Size s)
            : this ((double)p.x, (double)p.y, (double)s.width, (double)s.height)
        {

        }

        public Rect2d (double[] vals)
        {
            set (vals);
        }

        public void set (double[] vals)
        {
            if (vals != null)
            {
                x = vals.Length > 0 ? (double)vals[0] : 0;
                y = vals.Length > 1 ? (double)vals[1] : 0;
                width = vals.Length > 2 ? (double)vals[2] : 0;
                height = vals.Length > 3 ? (double)vals[3] : 0;
            }
            else
            {
                x = 0;
                y = 0;
                width = 0;
                height = 0;
            }
        }

        public Rect2d clone ()
        {
            return new Rect2d (x, y, width, height);
        }

        public Point tl ()
        {
            return new Point (x, y);
        }

        public Point br ()
        {
            return new Point (x + width, y + height);
        }

        public Size size ()
        {
            return new Size (width, height);
        }

        public double area ()
        {
            return width * height;
        }

        public bool empty ()
        {
            return width <= 0 || height <= 0;
        }

        public bool contains (Point p)
        {
            return x <= p.x && p.x < x + width && y <= p.y && p.y < y + height;
        }

        //@Override
        public override int GetHashCode ()
        {
            const int prime = 31;
            int result = 1;
            long temp;
            temp = BitConverter.DoubleToInt64Bits (height);
            result = prime * result + (int)(temp ^ (Utils.URShift (temp, 32)));
            temp = BitConverter.DoubleToInt64Bits (width);
            result = prime * result + (int)(temp ^ (Utils.URShift (temp, 32)));
            temp = BitConverter.DoubleToInt64Bits (x);
            result = prime * result + (int)(temp ^ (Utils.URShift (temp, 32)));
            temp = BitConverter.DoubleToInt64Bits (y);
            result = prime * result + (int)(temp ^ (Utils.URShift (temp, 32)));
            return result;
        }

        //@Override
        public override bool Equals (Object obj)
        {
            if (this == obj)
                return true;
            if (!(obj is Rect2d))
                return false;
            Rect2d it = (Rect2d)obj;
            return x == it.x && y == it.y && width == it.width && height == it.height;
        }

        //@Override
        public override String ToString ()
        {
            return "{" + x + ", " + y + ", " + width + "x" + height + "}";
        }

        //
        #region Operators

        public static Rect2d operator + (Rect2d rect, Point pt)
        {
            return new Rect2d (rect.x + (int)pt.x, rect.y + (int)pt.y, rect.width, rect.height);
        }

        public static Rect2d operator - (Rect2d rect, Point pt)
        {
            return new Rect2d (rect.x - (int)pt.x, rect.y - (int)pt.y, rect.width, rect.height);
        }

        public static Rect2d operator + (Rect2d rect, Size size)
        {
            return new Rect2d (rect.x, rect.y, rect.width + (int)size.width, rect.height + (int)size.height);
        }

        public static Rect2d operator - (Rect2d rect, Size size)
        {
            return new Rect2d (rect.x, rect.y, rect.width - (int)size.width, rect.height - (int)size.height);
        }

        public static Rect2d operator & (Rect2d a, Rect2d b)
        {
            return intersect (a, b);
        }

        public static Rect2d operator | (Rect2d a, Rect2d b)
        {
            return union (a, b);
        }

        #endregion

        public bool contains (double x, double y)
        {
            return this.x <= x && x < this.x + this.width && this.y <= y && y < this.y + this.height;
        }

        public bool contains (Rect2d rect)
        {
            return x <= rect.x &&
                (rect.x + rect.width) <= (x + width) &&
                y <= rect.y &&
                (rect.y + rect.height) <= (y + height);
        }

        public void inflate (double width, double height)
        {
            this.x -= width;
            this.y -= height;
            this.width += (2 * width);
            this.height += (2 * height);
        }

        public void inflate (Size size)
        {
            inflate ((double)size.width, (double)size.height);
        }

        public static Rect2d inflate (Rect2d rect, double x, double y)
        {
            rect.inflate (x, y);
            return rect;
        }

        public static Rect2d intersect (Rect2d a, Rect2d b)
        {
            double x1 = Math.Max (a.x, b.x);
            double x2 = Math.Min (a.x + a.width, b.x + b.width);
            double y1 = Math.Max (a.y, b.y);
            double y2 = Math.Min (a.y + a.height, b.y + b.height);

            if (x2 >= x1 && y2 >= y1)
                return new Rect2d (x1, y1, x2 - x1, y2 - y1);
            return null;
        }

        public Rect2d intersect (Rect2d rect)
        {
            return intersect (this, rect);
        }

        public bool intersectsWith (Rect2d rect)
        {
            return (
                (x < rect.x + rect.width) &&
                (x + width > rect.x) &&
                (y < rect.y + rect.height) &&
                (y + height > rect.y)
                );
        }

        public Rect2d union (Rect2d rect)
        {
            return union (this, rect);
        }

        public static Rect2d union (Rect2d a, Rect2d b)
        {
            double x1 = Math.Min (a.x, b.x);
            double x2 = Math.Max (a.x + a.width, b.x + b.width);
            double y1 = Math.Min (a.y, b.y);
            double y2 = Math.Max (a.y + a.height, b.y + b.height);

            return new Rect2d (x1, y1, x2 - x1, y2 - y1);
        }
        //
    }
}
