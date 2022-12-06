
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //DTO Data Transformation Object

        ProductTest();
        //Console.WriteLine();
        //Console.WriteLine();
        //Console.WriteLine();
        //Console.WriteLine();
        //CategoryTest();
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void ProductTest()
    {
       // Console.WriteLine("Hello, World!");
        ProductManager productManager = new ProductManager(new EfProductDal());
        // productManager.Add(new Product { ProductId=78,CategoryId=1,ProductName="dd",UnitPrice=11,UnitsInStock=11});
        var result = productManager.GetProductDetails();
        if (result.Success)
        {
            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName + "   berkan  " + product.CategoryName);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }



    }
}