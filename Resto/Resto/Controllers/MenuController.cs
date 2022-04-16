using Microsoft.AspNetCore.Mvc;
using Resto.Data;
using Resto.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Resto.Controllers
{
    public class MenuController : Controller
    {

        private readonly TeamDbContext _Teamcontext;
        private readonly MenuDbContext _Menucontext;

        public MenuController(TeamDbContext Teamcontext, MenuDbContext Menucontext)
        {
            _Teamcontext = Teamcontext;
            _Menucontext = Menucontext;


            List<Menu> statuses = new List<Menu>();

            foreach (var entity in _Menucontext.Menues)
            {

                _Menucontext.Menues.Remove(entity);
            }
                _Menucontext.SaveChanges();

            statuses.ForEach(n => _Menucontext.Menues.Add(n));
            _Menucontext.SaveChanges();


            statuses.Add(new Menu { Category_name = null, Meal_name = "Australian Organic Beef", Meal_info = null, Meal_shortinfo = null, Meal_price = 0, Meal_image = "~/img/hero-1.jpg" });
            statuses.Add(new Menu { Category_name = null, Meal_name = null, Meal_info = null, Meal_shortinfo = null, Meal_price = 0, Meal_image = "~/img/hero-2.jpg" });
            statuses.Add(new Menu { Category_name = null, Meal_name = null, Meal_info = null, Meal_shortinfo = null, Meal_price = 0, Meal_image = "~/img/hero-3.jpg" });
            statuses.Add(new Menu { Category_name = "Beef", Meal_name = "Steak Sauce", Meal_info = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Cupiditate, ea vero alias perferendis quas animi doloribus voluptates. Atque explicabo ea nesciunt provident libero qui eum, corporis esse quos excepturi soluta?", Meal_shortinfo = null, Meal_price = 15.0m, Meal_image = "~/img/steak.jpg" });
            statuses.Add(new Menu { Category_name = "Salmon", Meal_name = "Zucchini", Meal_info = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Blanditiis, accusamus culpa quam amet ipsam odit ea doloremque accusantium quo, itaque possimus eius. In a quis quibusdam omnis atque vero dolores!", Meal_shortinfo = null, Meal_price = 12.0m, Meal_image = "~/img/salmon-zucchini.jpg" });
            statuses.Add(new Menu { Category_name = "Breakfast", Meal_name = "Egg Sandwich", Meal_info = null, Meal_shortinfo = "Meat Ball, Mie", Meal_price = 30.0m, Meal_image = "~/img/breakfast-1.jpg" });

            statuses.ForEach(n => _Menucontext.Menues.Add(n));
            _Menucontext.SaveChanges();

            List<Team> statuses2 = new List<Team>();

            foreach (var entity in _Teamcontext.Teams)
            {

                _Teamcontext.Teams.Remove(entity);
            }
                _Teamcontext.SaveChanges();

            statuses2.Add(new Team { Name = "Aaron Patel", Position = "CEO", Team_image = "~/img/chef-1.jpg" });
            statuses2.Add(new Team { Name = "Daniel Tebas", Position = "Chef", Team_image = "~/img/chef-2.jpg" });
            statuses2.Add(new Team { Name = "Jon Snow", Position = "Chef", Team_image = "~/img/chef-3.jpg" });

            statuses2.ForEach(n => _Teamcontext.Teams.Add(n));
            _Teamcontext.SaveChanges();
        }

        public GeneralModel GeneralModel()
        {


            var model = new GeneralModel
            {
                Teams = _Teamcontext.Teams.ToList(),
                Menues = _Menucontext.Menues.ToList()
            };

            return model;
        }
        public IActionResult Index()
        {

            return View(GeneralModel());
        }

        public IActionResult About()
        {

            return View("About", GeneralModel());
        }

        public IActionResult Specialdishes()
        {

            return View("Specialdishes", GeneralModel());
        }

        public IActionResult Menu()
        {

            return View("Menu", GeneralModel());
        }

        public IActionResult Team()
        {

            return View("Team", GeneralModel());
        }

    }
}
