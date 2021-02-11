using Assignment4_DevynSmith_Section3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4_DevynSmith_Section3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Home page view
        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                if (r.FavoriteDish == null | r.FavoriteDish == "")
                {
                    r.FavoriteDish = "It's all tasty!";
                }
                if (r.Link == null | r.Link == "")
                {
                    r.Link = "Coming Soon";
                }
                restaurantList.Add($"<b>Rank {r.Rank}</b> <br> Restaurant: {r.RestaurantName} <br> Favorite Dish: {r.FavoriteDish} <br> Address: {r.Address} <br> Phone: {r.RestaurantPhone} <br> Website: <a href=\"{r.Link}\">{r.Link}</a> <br>");
            }

            return View(restaurantList);
        }

        //addsuggestion get view
        [HttpGet]
        public IActionResult AddSuggestion()
        {
            return View();
        }

        //addsuggestion post view
        [HttpPost]
        public IActionResult AddSuggestion(AddSuggestionResponse suggestionResponse)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddSuggestion(suggestionResponse);
                return View("Confirmation", suggestionResponse);
            }
            else
            {
                return View();
            }
        }

        //view restaurants view
        public IActionResult RestaurantList()
        {
            foreach (AddSuggestionResponse s in TempStorage.Suggestions)
            {
                if (s.FavoriteDish == null | s.FavoriteDish == "")
                {
                    s.FavoriteDish = "It's all tasty!";
                }
            }
            return View(TempStorage.Suggestions);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
