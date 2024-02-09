using Microsoft.AspNetCore.Mvc;
using StreamingCalculator.Models;

namespace StreamingCalculator.Controllers
{
    public class RoyaltyCalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new RoyaltyCalculatorModel(); // Replace with your actual model class name
            return View(model);
        }


        [HttpPost]
        public IActionResult Index(RoyaltyCalculatorModel model) // Replace with your actual model class name
        {
            if (!ModelState.IsValid)
            {
                // Handle invalid model state
                return View(model);
            }

            // Logic for a valid model

            return View(model);
        }

    }
}
