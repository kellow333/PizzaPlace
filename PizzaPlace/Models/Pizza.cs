using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Models
{
    public class Pizza
    {
        [ScaffoldColumn(false)]
        public int PizzaID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string PizzaName { get; set; }

        [Required, StringLength(1000), Display(Name = "Pizza Description")]
        public string PizzaDescription { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }

    }
}