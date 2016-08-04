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
        
        [HttpPost]
        public IActionResult Create(RestaurantEditViewModel model)
        {
            if (ModelState.IsValid)
            {

                var restaurant = new Restaurant
                {
                    Name = model.Name,
                    Cuisine = model.Cuisine
                };
                _restaurantData.Add(restaurant);
                _restaurantData.Commit();

                return RedirectToAction("Details", new { id = restaurant.Id });
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _restaurantData.Get(id);
            if (model == null)
                return RedirectToAction("Index");
            return View(model);
        }
        
        [HttpPost]
        public IActionResult Edit(int id, RestaurantEditViewModel input)
        {
            var restaurant = _restaurantData.Get(id);
            if (ModelState.IsValid && restaurant != null)
            {
                restaurant.Name = input.Name;
                restaurant.Cuisine = input.Cuisine;
                _restaurantData.Commit();

                return RedirectToAction("Details", new { id = restaurant.Id });
            }

            return View(restaurant);
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
