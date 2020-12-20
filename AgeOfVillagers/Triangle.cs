using System.Drawing;


namespace AgeOfVillagers
{
    public class Triangle : Composite
    {
        public Triangle(Point point_1, Point point_2, Point point_3)
        {
            AddComponent(new Line(point_1, point_2));
            AddComponent(new Line(point_2, point_3));
            AddComponent(new Line(point_3, point_1));
        }
    }
}
