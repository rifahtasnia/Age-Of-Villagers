using System.Drawing;

namespace AgeOfVillagers.Arab_Bedouin
{
    public class ArabBedouinTrees : Composite
    {

        public ArabBedouinTrees(Point point)
        {
            Point leftPoint1 = new Point(point.X + 8, point.Y - 4);
            Point rightPoint1 = new Point(point.X - 8, point.Y - 4);
            Point leftPoint2 = new Point(point.X + 6, point.Y - 8);
            Point rightPoint2 = new Point(point.X - 6, point.Y - 8);
            Point topMost = new Point(point.X, point.Y - 10);
            Point TopLeft = new Point(point.X - 1, point.Y);
            Point RightBottom = new Point(point.X + 1, point.Y + 14);

            AddComponent(new Rectangle(TopLeft, RightBottom));
            AddComponent(new Line(point, leftPoint1));
            AddComponent(new Line(point, rightPoint1));
            AddComponent(new Line(point, leftPoint2));
            AddComponent(new Line(point, rightPoint2));
            AddComponent(new Line(point, topMost));
        }
    }
}
