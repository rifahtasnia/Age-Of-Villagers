using System.Drawing;

namespace AgeOfVillagers.Egyptian_Kings
{
    public class EgyptianKings : INation
    {
        public Color BackgroundColor()
        {
            return Color.Yellow;
        }

        public IShape DrawHouse(Point point)
        {
            Composite egyptianHouse = new EgyptianKingsHouse(point);
            //egyptianHouse.Draw(g);
            return egyptianHouse;
        }

        public IShape DrawTree(Point point)
        {
            Composite egyptianTrees = new EgyptianKingsTrees(point);
            //egyptianTrees.Draw(g);
            return egyptianTrees;
        }

        public IShape DrawWaterSource(Point point)
        {
            Composite egyptianWaterSource = new EgyptianKingsWatersource(point);
            //egyptianWaterSource.Draw(g);
            return egyptianWaterSource;
        }
    }
}
