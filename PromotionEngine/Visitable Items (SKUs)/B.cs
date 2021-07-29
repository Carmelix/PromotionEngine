using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class B : Visitable
    {
        public float Price => 30;

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
