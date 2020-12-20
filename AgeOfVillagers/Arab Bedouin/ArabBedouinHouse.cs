using System.Drawing;

namespace AgeOfVillagers.Arab_Bedouin
{
    public class ArabBedouinHouse : Composite
    {
        public ArabBedouinHouse(Point point)
        {
            Point bottomLeft = new Point(point.X - 6, point.Y + 12);
            Point bottomRight = new Point(point.X + 6, point.Y + 12);
            Point topMost = new Point(point.X + 4, point.Y - 4);
            Point rightMost = new Point(point.X + 10, point.Y + 8);


            AddComponent(new Triangle(point, bottomLeft, bottomRight));
            AddComponent(new Line(point, topMost));
            AddComponent(new Line(bottomRight, rightMost));
            AddComponent(new Line(topMost, rightMost));

        }
    }
}
