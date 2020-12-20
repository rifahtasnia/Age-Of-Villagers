using System.Drawing;

namespace AgeOfVillagers.Bangladeshi_Farmers
{
    public class BDFarmersWatersource : Composite
    {
        public BDFarmersWatersource(Point Point1)
        {
            Point point2 = new Point(Point1.X - 7, Point1.Y + 1);
            Point point3 = new Point(Point1.X - 11, Point1.Y + 10);
            Point point4 = new Point(Point1.X - 3, Point1.Y + 14);
            Point point5 = new Point(Point1.X + 3, Point1.Y + 8);
            Point point6 = new Point(Point1.X + 9, Point1.Y + 12);
            Point point7 = new Point(Point1.X + 13, Point1.Y + 5);
            Point point8 = new Point(Point1.X + 7, Point1.Y - 2);
            Point point9 = new Point(Point1.X, Point1.Y + 4);

            AddComponent(new Line(Point1, point2));
            AddComponent(new Line(point2, point3));
            AddComponent(new Line(point3, point4));
            AddComponent(new Line(point4, point5));
            AddComponent(new Line(point5, point6));
            AddComponent(new Line(point6, point7));
            AddComponent(new Line(point7, point8));
            AddComponent(new Line(point8, point9));
            AddComponent(new Line(point9, Point1));
        }
    }
}
