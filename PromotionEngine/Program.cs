using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Visitable> shoppingChart = new List<Visitable>()
            {
                new A(),new A(),new A(),
                new B(),new B(),new B(),new B(),new B(),
                new C(),
                new D()
            };

            ProductVisitor productVisitor = new ProductVisitor();
            DiscountVisitor discountVisitor = new DiscountVisitor();

            foreach (Visitable item in shoppingChart)
            {
                item.Accept(productVisitor);
                item.Accept(discountVisitor);
            }

            Console.WriteLine(productVisitor.TotalCost - discountVisitor.GetTotalDiscount());

        }
    }
}
