﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using tp2JordanCoutureLafranchise.Models;
using tp2JordanCoutureLafranchise.Models.Data;
using tp2JordanCoutureLafranchise.ViewModels;

namespace tp2JordanCoutureLafranchise.Controllers
{
    public class GestionEnfantController : Controller
    {


        private HockeyRebelsDBContext _BaseDonnees { get; set; }

        public GestionEnfantController(HockeyRebelsDBContext BaseDeDonnees)
        {
            _BaseDonnees = BaseDeDonnees;
        }


        // GET: GestionEnfantController/Delete/5
        public ActionResult Delete(int id)
        {
            Enfant joueur = _BaseDonnees.Enfants.Where(x => x.Id == id).FirstOrDefault();

           
            return View(joueur);
        }

        // POST: GestionEnfantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var enfantasuprimmer = _BaseDonnees.Enfants.Where(x => x.Id == id).Single();
            //supprimer l'enfant avec l'id passé en parametre de la
            // BD et de la liste des enfants de son parent
            if (ModelState.IsValid)
            {
                _BaseDonnees.Enfants.Remove(enfantasuprimmer);
                _BaseDonnees.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(enfantasuprimmer);
        }

        public IActionResult Create()
        {
            ViewData["titre"] = "Ajouter une équipe";
            var enfantVM = new EnfantVM
            {
                Enfant = new Enfant() // Create a new Enfant instance with default values
            };
            enfantVM.ParentSelectList = _BaseDonnees.Parents.Select(t => new SelectListItem
            {
                Text = t.Nom,
                Value = t.ParentId.ToString()
            }).OrderBy(t => t.Text);

            return View(enfantVM);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EnfantVM enfantVM)
        {
            if (ModelState.IsValid)
            {
                enfantVM.Enfant.Equipe = _BaseDonnees.Parents.FirstOrDefault(p => p.ParentId == enfantVM.Enfant.ParentId)?.Nom;

                ViewData["titre"] = "Ajouter un joueur";
                _BaseDonnees.Add(enfantVM.Enfant);
                _BaseDonnees.SaveChanges();
                return RedirectToAction("index", "Home");
            }
            enfantVM.ParentSelectList = _BaseDonnees.Parents.Select(t => new SelectListItem
            {
                Text = t.Nom,
                Value = t.ParentId.ToString()
            }).OrderBy(t => t.Text);


            return View(enfantVM);

        }




    }
}
