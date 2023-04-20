
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Repositories;
using ToDoList.ViewModel;

namespace ToDoList.Controllers
{
    public class ThingController : Controller
    {
        private readonly ThingRepository _thingRepository;

        public ThingController(ThingRepository thingRepository)
        {
            _thingRepository = thingRepository;
        }

        public IActionResult Index()
        {
            var things = _thingRepository.GetThings();
            var categories = _thingRepository.GetCategories();
            var viewModel = new ThingsViewModel
            {
                Things = things,
                Categories = categories
            };
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            return View("Index");
        }
        [HttpGet]
        public IActionResult GetThings()
        {
            return View("Index");
        }
        [HttpPost]
        public IActionResult Create(CreateThingViewModel model)
        {
            if (ModelState.IsValid)
            {
                var thing = new DoThing
                {
                    Thing = model.Thing,
                    Due = model.Due,
                    IsDone = model.IsDone,
                    IdCategory = model.CategoryId
                };
                _thingRepository.CreateThing(thing);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(DeleteThingViewModel model)
        {
            _thingRepository.DeleteThing(model.Id);
            return RedirectToAction("Index");
        }
    }
}