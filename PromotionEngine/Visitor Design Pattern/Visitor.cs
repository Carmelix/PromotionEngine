using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public abstract class Visitor
    {
        public abstract void Visit(A a);
        public abstract void Visit(B b);
        public abstract void Visit(C c);
        public abstract void Visit(D d);
    }
}
