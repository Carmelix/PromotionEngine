using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class D : Visitable
    {
        public float Price => 15;

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
