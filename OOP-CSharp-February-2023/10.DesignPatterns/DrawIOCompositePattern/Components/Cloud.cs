using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawIOCompositePattern.Components
{
    public class Cloud : DrawableComponent
    {
        public Cloud(Position position) : base(position)
        {
        }

        public override char[,] GetShapeMatrix()
        {
            return new char[,]
            {
                { ' ',' ','*',' ', },
                { ' ','*',' ','*', },
                { '*',' ',' ','*', },
                { ' ',' ','*',' ', },
                { ' ','*',' ',' ', },

            };
        }
    }
}
