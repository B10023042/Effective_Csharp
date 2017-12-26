using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveCsharp._01
{
    class DefineClass
    {
        void Define()
        {
            var exampleString = "I'am String";
            var exampleInt = 25;
            var exampleDict = new Dictionary<string, int>();
            var exampleProduct = new CommonProduct();
            var exampleProduct2 = ProductFactory.CreateProduct(ProductEnum.Industry);


            var exampleResult = exampleProduct.Report();
            var Parameter = 1;



            var result = SomeObject.DoSomeWork(Parameter);
            int result2= SomeObject.DoSomeWork(Parameter);



            var num = SomeObject.DoSomeWork(Parameter);
            var workNum = SomeObject.DoSomeWork(Parameter);
        }

    }

    internal class SomeObject
    {
        internal static int DoSomeWork(int parameter)
        {
            return parameter;
        }
    }

    static class ProductFactory
    {
        public static IProduct CreateProduct(ProductEnum productCode)
        {
            switch (productCode)
            {
                case ProductEnum.Industry:
                    return new IndustryProduct();
                case ProductEnum.SuperIndustry:
                    return new SuperIndustryProduct();
                default:
                    return new CommonProduct();
            }
        }
    }
    public interface IProduct
    {
        String Report();
    }
    class IndustryProduct : IProduct
    {
        public String Report()
        {
            return "This Report is About Industry Product.";
        }
    }

    class SuperIndustryProduct : IProduct
    {
        public String Report()
        {
            return "This Report is About Super Industry Product.";

        }
    }
    class CommonProduct : IProduct
    {
        public String Report()
        {
            return "This Report is About Common Product.";

        }
    }


    enum ProductEnum { Industry, SuperIndustry }
}
