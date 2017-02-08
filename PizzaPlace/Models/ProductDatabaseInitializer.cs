using System.Collections.Generic;
using System.Data.Entity;

namespace PizzaPlace.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetPizzas().ForEach(p => context.Pizzas.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Classic"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Specialty"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Italiano"
                },
            };
            return categories;
        }

        private static List<Pizza> GetPizzas()
        {
            var pizzas = new List<Pizza> {
                new Pizza
                {
                    PizzaID = 1,
                    PizzaName = "Margarita",
                    PizzaDescription = "Cheese and Tomato pizza",
                    ImagePath = "margarita.jpg",
                    UnitPrice = 9.99,
                    CategoryID = 1
                },
                new Pizza
                {
                    PizzaID = 2,
                    PizzaName = "Meat Feast",
                    PizzaDescription = "Red Onions, mushrooms, pepperoni, ham, ground beef, sausage",
                    ImagePath = "meat-feast.jpg",
                    UnitPrice = 12.99,
                    CategoryID = 2
                },
                new Pizza
                {
                    PizzaID = 1,
                    PizzaName = "Milano",
                    PizzaDescription = "Ventricina salami & proscuitto ham",
                    ImagePath = "milano.jpg",
                    UnitPrice = 15.99,
                    CategoryID = 3
                },
            };
            return pizzas;
        }
    }
}