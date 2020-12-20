using System.Drawing;

namespace AgeOfVillagers.Arab_Bedouin
{
    public class ArabBedouin : INation
    {
        public Color BackgroundColor()
        {

            return Color.GreenYellow;
        }

        public IShape DrawHouse(Point point)
        {
            Composite arabBedouinHouse = new ArabBedouinHouse(point);
            //arabBedouinHouse.Draw(g);
            return arabBedouinHouse;
        }

        public IShape DrawTree(Point point)
        {
            Composite arabBedouinTree = new ArabBedouinTrees(point);
            //arabBedouinTree.Draw(g);
            return arabBedouinTree;
        }

        public IShape DrawWaterSource(Point point)
        {
            Composite arabBedouinWaterSource = new NullItems();
            //arabBedouinWaterSource.drawing();
            return arabBedouinWaterSource;
        }
    }
}
