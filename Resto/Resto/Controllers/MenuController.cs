using Microsoft.AspNetCore.Mvc;
using Resto.Data;
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
