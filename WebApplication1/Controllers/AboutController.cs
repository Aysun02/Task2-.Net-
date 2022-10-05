using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.About;
using WebApplication1.ViewModels.About;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication1.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            var projectComponents = new List<ProjectComponent>
            {
                new ProjectComponent{ Heading = "Our Vision", Text = "Our Vision's Text", Icon="display-4 bx bxs-bulb text-light"},
                new ProjectComponent{ Heading = "Our Mission", Text = "Our Mission's Text", Icon="display-4 bx bx-revision text-light"}, 
                new ProjectComponent{ Heading = "Our Goal", Text = "Our Goal's Text", Icon = "display-4 bx bxs-select-multiple text-light"}
            };

            var model = new AboutIndexViewModel
            { 
                ProjectComponents = projectComponents
            };

            return View(model);
        }
    }
}
