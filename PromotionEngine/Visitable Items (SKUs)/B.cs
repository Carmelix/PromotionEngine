using System;


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
