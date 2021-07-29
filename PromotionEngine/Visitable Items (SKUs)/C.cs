using System;


namespace PromotionEngine
{
    public class C : Visitable
    {
        public float Price => 20;

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
