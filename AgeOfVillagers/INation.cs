using System.Drawing;

namespace AgeOfVillagers
{
    public interface INation
    {
        IShape DrawTree(Point point);
        IShape DrawHouse(Point point);
        IShape DrawWaterSource(Point point);
        Color BackgroundColor();
    }

}
