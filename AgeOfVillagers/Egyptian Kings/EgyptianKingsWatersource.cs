using System.Drawing;

namespace AgeOfVillagers.Egyptian_Kings
{
    public class EgyptianKingsWatersource : Composite
    {
        public EgyptianKingsWatersource(Point point)
        {
            Point topPoint = new Point(point.X + 12, point.Y + 12);
            AddComponent(new Ellipse(point, topPoint));
        }
    }
}
