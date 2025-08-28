using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class ToanController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ToanModel model)
        {
            switch (model.PhepToan)
            {
                case "Tong":
                    model.KetQua = model.SoThuNhat + model.SoThuHai;
                    break;
                case "Hieu":
                    model.KetQua = model.SoThuNhat - model.SoThuHai;
                    break;
                case "Tich":
                    model.KetQua = model.SoThuNhat * model.SoThuHai;
                    break;
                case "Thuong":
                    if (model.SoThuHai != 0)
                        model.KetQua = model.SoThuNhat / model.SoThuHai;
                    else
                        ViewBag.Message = "❌ Không thể chia cho 0!";
                    break;
            }

            if (ViewBag.Message== null)
                ViewBag.Message = $"✅ Kết quả: {model.KetQua}";

            return View(model);
        }
    }
}
