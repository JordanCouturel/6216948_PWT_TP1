﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tp2JordanCoutureLafranchise.Models;
using tp2JordanCoutureLafranchise.Models.Data;

namespace tp2JordanCoutureLafranchise.Controllers
{
    public class HomeController : Controller
    {

        private HockeyRebelsDBContext _BaseDonnees { get; set; }

        public HomeController(HockeyRebelsDBContext BaseDeDonnees)
        {
            _BaseDonnees = BaseDeDonnees;
        }



        public IActionResult Index()
        {
            ViewData["titre"] = "Accueil";
            var listeparents = _BaseDonnees.Parents.ToList();


            return View(listeparents);
        }

        public ActionResult Delete(int id)
        {
            Parent equipe = _BaseDonnees.Parents.Where(x => x.ParentId == id).FirstOrDefault();

            return View(equipe);
        }

        // POST: GestionEnfantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var parentasupprimer = _BaseDonnees.Parents.Where(x => x.ParentId == id).Single();
            //supprimer l'enfant avec l'id passé en parametre de la
            // BD et de la liste des enfants de son parent

            if (ModelState.IsValid)
            {
                _BaseDonnees.Parents.Remove(parentasupprimer);
                _BaseDonnees.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(parentasupprimer);

        }

        public IActionResult Create()
        {
            ViewData["titre"] = "Ajouter une équipe";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Parent parent)
        {
            if (ModelState.IsValid)
            {
                ViewData["titre"] = "Ajouter une équipe";
                _BaseDonnees.Parents.Add(parent);
                _BaseDonnees.SaveChanges();
                return RedirectToAction("index", "Home");
            }
            return View(parent);


        }

    }
}