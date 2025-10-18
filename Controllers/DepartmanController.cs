using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc_postgresql.Data;
using mvc_postgresql.Models;

namespace mvc_postgresql.Controllers
{
    public class DepartmanController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DepartmanController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var departmanlar = _context.Departmanlar
                               .Include(d => d.Personeller)
                               .ToList();
            return View(departmanlar);
      
        }
        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Departman departman)
        {
            try
            {
                _context.Departmanlar.Add(departman);
                _context.SaveChanges();
                TempData["msg"] = "✅ Kayıt başarılı!";
            }
            catch (Exception ex)
            {
                TempData["msg"] = "❌ HATA: " + ex.Message;
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var departman = _context.Departmanlar.FirstOrDefault(x => x.Id == id);
            if (departman == null)
            {
                return NotFound();
            }

            _context.Departmanlar.Remove(departman);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }



    }
}
