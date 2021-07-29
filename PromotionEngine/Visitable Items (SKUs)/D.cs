using System;


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
