using FirstTask.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.ShapeCreators
{
    public interface IShapeCreator
    {
        Shape Create();
    }
}
