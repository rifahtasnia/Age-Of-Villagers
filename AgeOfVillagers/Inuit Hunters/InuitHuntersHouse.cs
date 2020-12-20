using System.Drawing;

namespace AgeOfVillagers.Inuit_Hunters
{
    public class InuitHuntersHouse : Composite
    {
        public InuitHuntersHouse(Point point)
        {
            Point LeftBottom = new Point(point.X - 8, point.Y + 8);
            Point RightBottom = new Point(point.X + 8, point.Y + 8);

            AddComponent(new Line(LeftBottom, RightBottom));
            AddComponent(new Arc(point.X - 4, point.Y + 5, 7, 7, 180.0F, 180.0F));
            AddComponent(new Arc(point.X - 8, point.Y, 16, 16, 180.0F, 180.0F));
        }
    }
}
