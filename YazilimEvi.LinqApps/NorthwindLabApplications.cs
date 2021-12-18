using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimEvi.LinqApps.DAL;

namespace YazilimEvi.LinqApps
{
    public  class NorthwindLabApplications
    {
        public static void GetEmployeeList()
        {
            List<Employee> list = null ;

            list.ForEach(e => Console.WriteLine($"{e.EmployeeId,-5} " +
                $"{e.FirstName,-15} " +
                $"{e.LastName,-15}"));
        }

        public static void GetAverageProductPrice()
        {
            decimal averagePrice = 0;
            Console.WriteLine($"Average price : {averagePrice}");
        }

        public void GetProductAndSupplierList()
        {
            List<Product> list = null;

            foreach (var item in list)
            {
                Console.WriteLine($"{item.ProductId,-5} " +
                    $"{item.ProductName,-20}" +
                    $"{item.Supplier.CompanyName,-20}" +
                    $"{item.Supplier.City,-10}");
            }
        }
           
    }
}
