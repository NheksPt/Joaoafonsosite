using Joaoafonsosite.Domain.Entities;
using Joaoafonsosite.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Joaoafonsositeweb.Controllers
{
    public class TrabalhosController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TrabalhosController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var Trabalho = _db.Trabalho.ToList();
            return View(Trabalho);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Trabalhos obj)
        {


            if (ModelState.IsValid)
            {
                _db.Trabalho.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "O trabalho foi criado com sucesso.";
                return RedirectToAction("Index");
            }

            TempData["error"] = "O trabalho não foi criado.";
            return View(obj);
        }

        public IActionResult Editar(int trabalhoId)
        {
            Trabalhos? obj = _db.Trabalho.FirstOrDefault(u => u.Id == trabalhoId);

            if (obj is null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult Editar(Trabalhos obj)
        {
            if (ModelState.IsValid)
            {
                _db.Trabalho.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "O trabalho foi editado com sucesso.";
                return RedirectToAction("Index");
            }

            TempData["error"] = "O trabalho não foi editado.";
            return View(obj);

        }

        public IActionResult Apagar(int trabalhoId)
        {
            Trabalhos? obj = _db.Trabalho.FirstOrDefault(u => u.Id == trabalhoId);

            if (obj is null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult Apagar(Trabalhos obj)
        {
            Trabalhos? objFromDb = _db.Trabalho.FirstOrDefault(u => u.Id == obj.Id);

            if (objFromDb is not null)
            {
                _db.Trabalho.Remove(objFromDb);
                _db.SaveChanges();
                TempData["success"] = "O trabalho foi eliminado com sucesso.";
                return RedirectToAction("Index");
            }

            TempData["error"] = "O trabalho não foi eliminado.";
            return View(obj);
        }
    }
}
