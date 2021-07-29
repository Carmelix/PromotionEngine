using System;


namespace PromotionEngine
{
    public class ProductVisitor : Visitor
    {
        public float TotalCost { get; private set; }

        public override void Visit(A a)
        {
            TotalCost += a.Price;
        }

        public override void Visit(B b)
        {
            TotalCost += b.Price;
        }

        public override void Visit(C c)
        {
            TotalCost += c.Price;
        }

        public override void Visit(D d)
        {
            TotalCost += d.Price;
        }

    }
}
