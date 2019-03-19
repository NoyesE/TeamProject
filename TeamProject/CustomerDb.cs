using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    class CustomerDb
    {
        public static List<Customer> GetCustomers()
        {
            var context = new CoffeeDatabaseEntities();

            //SELECT * FROM Customers
            List<Customer> allCustomers =
                               (from c in context.Customer
                                select c).ToList();

            return allCustomers;
        }
        public static Customer AddCustomer(Customer c)
        {
            CoffeeDatabaseEntities context = new CoffeeDatabaseEntities();

            context.Customer.Add(c);

            context.SaveChanges();

            return c;
        }
        public static void DeleteCustomer(Customer c)
        {
            var context = new CoffeeDatabaseEntities();

            context.Entry(c).State = EntityState.Deleted;

            context.SaveChanges();
        }
        public static Customer Update(Customer c)
        {
            CoffeeDatabaseEntities context = new CoffeeDatabaseEntities();

            context.Entry(c).State = EntityState.Modified;

            context.SaveChanges();

            return c;
        }
    }
}
