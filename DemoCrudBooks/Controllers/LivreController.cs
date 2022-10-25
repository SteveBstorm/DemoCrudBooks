using Microsoft.AspNetCore.Mvc;
using DemoCrudBooks.FakeDB;
using DemoCrudBooks.Models.ViewModel;
using DemoCrudBooks.Models;

namespace DemoCrudBooks.Controllers
{
    public class LivreController : Controller
    {
        public IActionResult Index()
        {
            return View(LivreDB.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LivreForm form)
        {
            if (ModelState.IsValid)
            {
                Livre nouveauLivre = new Livre
                {
                    Titre = form.Titre,
                    Auteur = form.Auteur,
                    ISBN = form.ISBN
                };
                LivreDB.Ajouter(nouveauLivre);
                return RedirectToAction("Index");
            }
            return View(form);

        }

        public IActionResult Detail(int id)
        {
            Livre selected = LivreDB.GetById(id);
            return View(selected);
        }

        public IActionResult Delete(int id)
        {
            LivreDB.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            Livre selected = LivreDB.GetById(id);
            return View(selected);
        }

        [HttpPost]
        public IActionResult Update(Livre toUpdate)
        {
            LivreDB.Update(toUpdate);
            return RedirectToAction("Index");
        }
    }
}
