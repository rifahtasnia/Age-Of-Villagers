using System.Drawing;

namespace AgeOfVillagers.Egyptian_Kings
{
    public class EgyptianKingsHouse : Composite
    {

        public EgyptianKingsHouse(Point point)
        {
            Point bottomLeft = new Point(point.X - 9, point.Y + 14);
            Point bottomMost = new Point(point.X + 4, point.Y + 16);
            Point rightMost = new Point(point.X + 7, point.Y + 10);

            AddComponent(new Triangle(bottomMost, bottomLeft, point));
            AddComponent(new Triangle(rightMost, bottomMost, point));
        }
    }
}
