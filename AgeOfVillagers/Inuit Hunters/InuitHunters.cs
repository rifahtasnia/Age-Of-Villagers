using System.Drawing;

namespace AgeOfVillagers.Inuit_Hunters

{
    public class InuitHunters : INation
    {
        public Color BackgroundColor()
        {
            return Color.White;
        }

        public IShape DrawHouse(Point point)
        {
            Composite inuitHunterHouse = new InuitHuntersHouse(point);
            //inuitHunterHouse.Draw(g);
            return inuitHunterHouse;
        }

        public IShape DrawTree(Point point)
        {
            Composite inuitHunterTree = new NullItems();
            //inuitHunterTree.drawing();
            return inuitHunterTree;
        }

        public IShape DrawWaterSource(Point point)
        {
            Composite inuitHunterWaterSource = new NullItems();
            //inuitHunterWaterSource.drawing();
            return inuitHunterWaterSource;
        }
    }
}
