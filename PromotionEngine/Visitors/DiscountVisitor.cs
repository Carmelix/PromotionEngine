using System;


namespace PromotionEngine
{
    public class DiscountVisitor : Visitor
    {
        int nA;
        int nB;
        int nC;
        int nD;
                
        public override void Visit(A a)
        {
            nA++;
        }

        public override void Visit(B b)
        {
            nB++;
        }

        public override void Visit(C c)
        {
            nC++;
        }

        public override void Visit(D d)
        {
            nD++;
        }

        public float GetTotalDiscount()
        {
            float discount = 0;

            discount += (nA / 3) * 20;                  // 3 of A's for 130
            discount += (nB / 2) * 15;                  // 2 of B's for 45
            discount += Math.Min(nC, nD) * 5;           // C & D for 30

            return discount;    
        }
    }
}
