using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data;

namespace MyPortfolio.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            // FakeDatabase'deki kullanıcılara bakıyoruz
            var user = FakeDatabase.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                // Giriş başarılıysa ExperienceList sayfasına yönlendir
                return RedirectToAction("ExperienceList", "Experience");
            }

            // Hatalı giriş yapılırsa, hata mesajı göster
            ViewBag.Error = "Hatalı e-posta veya şifre!";
            return View();
        }
    }
}
