using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace PizzaPlace.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Category Description")]
        public string CategoryDescription { get; set; }

        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}