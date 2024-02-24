using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASSIGNMENT2.Controllers
{
    [Route("api/[controller]")]
    public class J1Controller : Controller
    {
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string CalorieCounter(int burger, int drink, int side, int dessert)
        {

            List<BurgerItems> BurgerItems = new List<BurgerItems>()
            {
                new BurgerItems() { Name = "Cheese burger", Calories = 461 },
                new BurgerItems() { Name = "Fish burger", Calories = 431 },
                new BurgerItems() { Name = "Veggie burger", Calories = 420 },
                new BurgerItems() { Name = "no burger", Calories = 0 },
            };
            List<Drinks> Drinks = new List<Drinks>()
            {
                new Drinks() { Name = "Soft Drink", Calories = 130 },
                new Drinks() { Name = "Orange Juice", Calories = 160 },
                new Drinks() { Name = "Milk", Calories = 118 },
                new Drinks() { Name = "no drink", Calories = 0 },
            };
            List<Sides> Sides = new List<Sides>()
            {
                new Sides() { Name = "Fries", Calories = 100 },
                new Sides() { Name = "Baked Potato", Calories = 57 },
                new Sides() { Name = "Chef Salad", Calories = 70 },
                new Sides() { Name = "no side order", Calories = 0 },
            };
            List<Desserts> Desserts = new List<Desserts>()
            {
                new Desserts() { Name = "Apple Pie", Calories = 167 },
                new Desserts() { Name = "Sundae", Calories = 266 },
                new Desserts() { Name = "Fruit Cup", Calories = 75 },
                new Desserts() { Name = "No Dessert", Calories = 0 },
            };

            int totalCalories =
                BurgerItems[burger - 1].Calories
                + Drinks[drink - 1].Calories
                + Sides[side - 1].Calories
                + Desserts[dessert - 1].Calories;

            string response = "Total Calories of this meal is: " + totalCalories;

            return response;
        }
    }

    public class Desserts
    {
        public string Name { get; set; }
        public int Calories { get; set; }
    }

    public class Sides
    {
        public string Name { get; set; }
        public int Calories { get; set; }
    }

    public class Drinks
    {
        public string Name { get; set; }
        public int Calories { get; set; }
    }

    public class BurgerItems
    {
        public string Name { get; set; }
        public int Calories { get; set; }
    }

}


