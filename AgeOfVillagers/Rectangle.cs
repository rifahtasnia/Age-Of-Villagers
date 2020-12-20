using System.Drawing;

namespace AgeOfVillagers
{
    public class Rectangle : Composite
    {
        public Rectangle(Point TopLeft, Point BottomRight)
        {
            Point TopRight = new Point(BottomRight.X, TopLeft.Y);
            Point BottomLeft = new Point(TopLeft.X, BottomRight.Y);

            AddComponent(new Line(TopLeft, BottomLeft));
            AddComponent(new Line(TopLeft, TopRight));
            AddComponent(new Line(BottomLeft, BottomRight));
            AddComponent(new Line(BottomRight, TopRight));
        }
    }
}
