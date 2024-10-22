using lab5.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab5.Controllers
{
    public class LineController : Controller
    {
        [HttpGet]
        public IActionResult DrawLine()
        {
            return View(new LineAttributes());
        }

        [HttpPost]
        public IActionResult DrawLine(LineAttributes model)
        {
            return View(model);  // Повертаємо модель з атрибутами лінії для відображення
        }
    }
}