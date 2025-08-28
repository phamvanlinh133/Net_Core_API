using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BMI model)
        {
            if (model.Height > 0)
            {
                model.Result = model.Weight / (model.Height * model.Height);

                if (model.Result < 18.5)
                {
                    ViewBag.Message = $"Chỉ số BMI của bạn là {model.Result:0.00} → Gầy";
                }
                else if (model.Result < 24.9)
                {
                    ViewBag.Message = $"Chỉ số BMI của bạn là {model.Result:0.00} → Bình thường";
                }
                else if (model.Result < 29.9)
                {
                    ViewBag.Message = $"Chỉ số BMI của bạn là {model.Result:0.00} → Thừa cân";
                }
                else
                {
                    ViewBag.Message = $"Chỉ số BMI của bạn là {model.Result:0.00} → Béo phì";
                }
            }
            else
            {
                ViewBag.Message = "Chiều cao phải lớn hơn 0!";
            }

            return View(model);
        }
    }
}
