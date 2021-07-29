using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using PromotionEngine;
namespace UnitTest
{
    [TestClass]
    public class PromotionEngine_UnitTest
    {
        private float GetTotal(List<Visitable> shoppingChart)
        {
            ProductVisitor productVisitor = new ProductVisitor();
            DiscountVisitor discountVisitor = new DiscountVisitor();

            foreach (Visitable item in shoppingChart)
            {
                item.Accept(productVisitor);
                item.Accept(discountVisitor);
            }

            return productVisitor.TotalCost - discountVisitor.GetTotalDiscount();
        }

        [TestMethod]
        public void ScenarioA_Test()
        {
            List<Visitable> shoppingChart = new List<Visitable>()
            {
                new A(),
                new B(),
                new C()
            };
                        
            Assert.IsTrue(GetTotal(shoppingChart) == 100);
        }

        [TestMethod]
        public void ScenarioB_Test()
        {
            List<Visitable> shoppingChart = new List<Visitable>()
            {
                new A(), new A(), new A(), new A(), new A(),
                new B(), new B(), new B(), new B(), new B(),
                new C()
            };

            Assert.IsTrue(GetTotal(shoppingChart) == 370);
        }

        [TestMethod]
        public void ScenarioC_Test()
        {
            List<Visitable> shoppingChart = new List<Visitable>()
            {
                new A(), new A(), new A(),
                new B(), new B(), new B(), new B(), new B(),
                new C(),
                new D()
            };

            Assert.IsTrue(GetTotal(shoppingChart) == 280);
        }
    }
}
