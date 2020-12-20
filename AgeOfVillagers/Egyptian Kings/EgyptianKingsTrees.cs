using System.Drawing;

namespace AgeOfVillagers.Egyptian_Kings
{
    public class EgyptianKingsTrees : Composite
    {

        public EgyptianKingsTrees(Point point)
        {
            Point mainRightBranch = new Point(point.X + 5, point.Y - 24);
            Point mainLeftBranch = new Point(point.X - 5, point.Y - 22);

            Point rightPoint = new Point(point.X + 3, point.Y - 12);
            Point rightPoint1 = new Point(point.X + 8, point.Y - 23);
            Point rightPoint2 = new Point(point.X + 1, point.Y - 24);

            Point leftPoint = new Point(point.X - 3, point.Y - 12);
            Point leftPoint1 = new Point(point.X - 8, point.Y - 22);
            Point leftPoint2 = new Point(point.X - 2, point.Y - 24);

            AddComponent(new Line(point, mainRightBranch));
            AddComponent(new Line(point, mainLeftBranch));
            AddComponent(new Line(rightPoint, rightPoint1));
            AddComponent(new Line(rightPoint, rightPoint2));
            AddComponent(new Line(leftPoint, leftPoint1));
            AddComponent(new Line(leftPoint, leftPoint2));
        }
    }
}
