using System.Drawing;

namespace AgeOfVillagers.Bangladeshi_Farmers
{
    public class BDFarmersHouse : Composite
    {
        public BDFarmersHouse(Point point)
        {
            Point TopLeft = new Point(point.X - 8, point.Y + 8);
            Point BottomRight = new Point(point.X + 8, point.Y + 16);
            Point TopRight = new Point(BottomRight.X, TopLeft.Y);

            AddComponent(new Rectangle(TopLeft, BottomRight));
            AddComponent(new Triangle(point, TopLeft, TopRight));
        }
    }
}
