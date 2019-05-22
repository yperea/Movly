using Movly.Models;
using System.Web.Mvc;

namespace Movly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {

            Movie movie = new Movie() {Name = "Shrek"};

            return View(movie);
        }
    }
}