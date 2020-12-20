using System.Collections.Generic;
using System.Drawing;

namespace AgeOfVillagers
{
    public abstract class Composite : IShape
    {
        protected List<IShape> My_components = new List<IShape>();

        protected void AddComponent(IShape myshape)
        {
            My_components.Add(myshape);
        }
        public void Draw(Pen p, Graphics g)
        {
            foreach (var component in My_components)
            {
                component.Draw(p, g);
            }
        }
    }
}
