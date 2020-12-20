using System.Drawing;

namespace AgeOfVillagers
{
    public class Line : IShape
    {
        private readonly Point point_1;
        private readonly Point point_2;

        public Line(Point point1, Point point2)
        {
            this.point_1 = point1;
            this.point_2 = point2;
        }

        public void Draw(Pen p, Graphics g)
        {
            //var my_pen = new Pen(Color.Black, 1);
            g.DrawLine(p, point_1, point_2);
        }
    }
}
