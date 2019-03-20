using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    static class CoffeeDb
    {
        public static List<Drink> GetAllCoffee()
        {
            using (CoffeeDatabaseEntities context = new CoffeeDatabaseEntities())
            {

                List<Drink> allCoffee =
                context.Drink.ToList();
                return allCoffee;
            }
        }

        public static void AddCoffee(Drink d)
        {
            using (CoffeeDatabaseEntities context = new CoffeeDatabaseEntities())
            {

                context.Drink.Add(d);
                context.SaveChanges();
            }
        }

        public static void Update(Drink d)
        {
            using (CoffeeDatabaseEntities context = new CoffeeDatabaseEntities())
            {
                context.Entry(d).State = System.Data.Entity.EntityState.Detached;
                context.Drink.Add(d);
                context.Entry(d).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
                
            
        }
    }
}
