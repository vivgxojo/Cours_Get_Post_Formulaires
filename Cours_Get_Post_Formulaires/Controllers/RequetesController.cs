using Cours_Get_Post_Formulaires.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Cours_Get_Post_Formulaires.Controllers
{
    public class RequetesController : Controller
    {
        [HttpGet]
        public ViewResult ReceptionRequeteGet(string nom)
        {
            ViewBag.Nom = nom;
            ViewBag.Prenom = this.Request.Query["prenom"];

            return View();
        }

        /// <summary>
        /// Méthode d'action qui affiche la page 
        /// dans laquelle il y a un lien.
        /// </summary>
        /// <returns>retourne la vue AfficherLien</returns>
        [HttpGet]
        public ViewResult AfficherLien()
        {
            return View();
        }

        /// <summary>
        /// Méthode d'action qui affiche un paragraphe qui donne 
        /// des détails sur le chemin et la valeur du paramètre envoyé dans l'URL.
        /// </summary>
        /// <param name="param">Un paramètre</param>
        /// <returns>Retourne une chaîne de caractères de type ContentResult</returns>
        [HttpGet]
        public ContentResult Lien(int param)
        {
            return Content("<p> Vous avez cliqué sur le lien qui mène vers <b>" + this.Request.Path +
                "</b> avec le paramètre <b>" + param + " </b></p>",
                "text/html", Encoding.UTF8);
        }
        
        [HttpGet]
        public ActionResult Formulaire()
        {
            return View("Saisie");
        }
        /*
        [HttpPost]
        public ActionResult Saisie(Etudiant etudiant)
        {
            return View("Affichage", etudiant);
        }
        */
        /*
        [HttpPost]
        public ActionResult Saisie(string numero, string nom, string prenom, string dateNaissance, string telephone)
        {
            Etudiant etudiant = new Etudiant();
            etudiant.Numero = Convert.ToInt32(numero);
            etudiant.Nom = nom;
            etudiant.Prenom = prenom;
            etudiant.DateNaissance = DateTime.Parse(dateNaissance);
            etudiant.Telephone = telephone;

            return View("Affichage", etudiant);
        }
        */
        /*
        [HttpPost]
        public ActionResult Saisie()
        {
            Etudiant etudiant = new Etudiant();
            etudiant.Numero = Convert.ToInt32(this.Request.Form["Numero"].ElementAt(0));
            etudiant.Nom = this.Request.Form["Nom"].ElementAt(0);
            etudiant.Prenom = this.Request.Form["Prenom"].ElementAt(0);
            etudiant.DateNaissance = DateTime.Parse(this.Request.Form["DateNaissance"].ElementAt(0));
            etudiant.Telephone = this.Request.Form["Telephone"].ElementAt(0);

            return View("Affichage", etudiant);
        }
        */
    }
}
