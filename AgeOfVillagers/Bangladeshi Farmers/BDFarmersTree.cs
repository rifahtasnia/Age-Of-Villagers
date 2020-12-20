using System.Drawing;

namespace AgeOfVillagers.Bangladeshi_Farmers
{
    public class BDFarmersTree : Composite
    {
        public BDFarmersTree(Point point)
        {
            Point TopPoint = new Point(point.X + 16, point.Y + 16);
            Point TopLeft = new Point(point.X + 6, point.Y + 8);
            Point BottomRight = new Point(point.X + 10, point.Y + 24);


            AddComponent(new Rectangle(TopLeft, BottomRight));
            AddComponent(new Ellipse(point, TopPoint));
        }
    }
}
