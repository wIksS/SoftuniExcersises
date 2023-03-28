using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawIOCompositePattern.Components
{
    public class Line : DrawableComponent
    {
        public Line(Position position) : base(position)
        {
        }

        public override char[,] GetShapeMatrix()
        {
            return new char[,]
            {
                { '-', },
                { '-', },
                { '-', },
                { '-', },
                { '-', },
                { '-', },
                { '-', },
                { '-', },

            };
        }
    }
}
