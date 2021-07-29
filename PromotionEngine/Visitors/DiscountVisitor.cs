using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            discount += (nA / 3) * 20;
            discount += (nB / 2) * 15;
            discount += ((int)Math.Sqrt(nC * nD)) * 5;
            
            return discount;    
        }
    }
}
