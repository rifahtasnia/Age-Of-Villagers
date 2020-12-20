using System.Drawing;

namespace AgeOfVillagers
{
    public class NullNation : INation
    {
        public Color BackgroundColor()
        {
            return Color.White;
        }

        public IShape DrawHouse(Point point)
        {
            Composite NullHouse = new NullItems();
            //NullHouse.drawing();
            return NullHouse;
        }

        public IShape DrawTree(Point point)
        {
            Composite NullTree = new NullItems();
            //NullTree.drawing();
            return NullTree;
        }

        public IShape DrawWaterSource(Point point)
        {
            Composite NullWaterSource = new NullItems();
            //NullWaterSource.drawing();
            return NullWaterSource;
        }
    }
}
