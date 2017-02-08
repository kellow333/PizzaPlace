using System.Data.Entity;

namespace PizzaPlace.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base("PizzaPlace")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}