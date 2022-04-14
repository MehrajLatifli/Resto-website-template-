using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resto.Entities
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public string Category_name { get; set; }
        public string Meal_name { get; set; }
        public string Meal_info { get; set; }
        public string Meal_shortinfo { get; set; }

        [Column(TypeName = "Money")]
        public decimal Meal_price { get; set; }

        public string Meal_image { get; set; }

        public Menu()
        {

        }
    }
}
