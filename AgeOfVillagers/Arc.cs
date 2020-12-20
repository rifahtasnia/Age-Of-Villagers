using System.Drawing;

namespace AgeOfVillagers
{
    public class Arc : IShape
    {
        public int x, y;
        private float width, height, StartAngle, SweepAngle;


        public Arc(int x, int y, float width, float height, float startAngle, float sweepAngle)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.StartAngle = startAngle;
            this.SweepAngle = sweepAngle;
        }

        public void Draw(Pen p, Graphics g)
        {
            //var my_pen = new Pen(Color.Black, 1);
            g.DrawArc(p, x, y, width, height, StartAngle, SweepAngle);
        }
    }

}
