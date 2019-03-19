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
            CoffeeDatabaseEntities context = new CoffeeDatabaseEntities();

            List<Drink> allCoffee =
                context.Drink.ToList();
            return allCoffee;
        }

        public static void AddCoffee(Drink d)
        {
            CoffeeDatabaseEntities context = new CoffeeDatabaseEntities();

            context.Drink.Add(d);
            context.SaveChanges();
        }
    }
}
