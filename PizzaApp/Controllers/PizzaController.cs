using Microsoft.AspNetCore.Mvc;
using PizzaApp.Database;
using PizzaApp.Models;
using PizzaApp.Models.Entities;
using System.Diagnostics;

namespace PizzaApp.Controllers
{   
    public class PizzaController : Controller
    {  
        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaDatabase.Pizzas;
            return View(pizzas);
        }
        public IActionResult Details(int id)
        {
            Pizza pizza = PizzaDatabase.Pizzas.FirstOrDefault(x => x.Id == id);

            if (pizza is null)
            {
                return RedirectToAction("Error");
            }

            return View(pizza);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //public IActionResult Details(int id)
        //{

        //}

        /*[Route("home")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [Route("create")]
        [HttpPost]
        public IActionResult Create()
        {
            return Ok("Success");
        }   
        [Route("{id}")]
        [HttpGet]
        public IActionResult GetPizzaName([FromQuery] int id)
        {
            return Ok($"{id}");
        }*/
    }
}
