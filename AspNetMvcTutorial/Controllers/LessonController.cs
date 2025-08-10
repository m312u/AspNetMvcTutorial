// Controllers/LessonController.cs
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcTutorial.Controllers
{
    public class LessonController : Controller
    {
        // 1. Introduction
        public IActionResult Introduction()
        {
            return View();
        }

        // 2. MVCの基本構造と流れ
        public IActionResult Routing()
        {
            return View();
        }

        // 3. Controllerの役割とHTTP属性の説明
        public IActionResult Controller()
        {
            return View();
        }

        // 4. モデルとバリデーション
        public IActionResult Validation()
        {
            return View();
        }

        // 5. ビューの役割とRazor構文
        public IActionResult ViewLesson()
        {
            return View();
        }

        // 6. Entity Framework（マイグレーション・最適化）
        public IActionResult EntityFramework()
        {
            return View();

        }

        // 7. 最後に
        public IActionResult Last()
        {
            return View();
        }

    }
}
