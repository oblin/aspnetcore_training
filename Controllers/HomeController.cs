using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using OdeToFood.Entities;
using OdeToFood.Services;
using OdeToFood.ViewModels;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IGreeter greeting, IRestaurantData restaurantData)
        {
            _greeter = greeting;
            _restaurantData = restaurantData;
        }

        private IGreeter _greeter;
        private IRestaurantData _restaurantData;

        public ViewResult Index()
        {
            var model = new HomePageViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentGreeting = _greeter.GetGreeting();

            return View(model);
        }

        public ViewResult Create()
        {
            return View();
        }
        
        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if (model == null)
                return NotFound();
            return View(model);
        }
    }
}
