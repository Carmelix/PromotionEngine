using System;


namespace PromotionEngine
{
    public class A : Visitable
    {
        public float Price => 50;

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
