using System;


namespace PromotionEngine
{
    public abstract class Visitable
    {
        public abstract void Accept(Visitor visitor);
    }
}
