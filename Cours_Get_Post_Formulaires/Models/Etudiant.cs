using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Cours_Get_Post_Formulaires.Models
{
    public class Etudiant
    {
        [Display(Name = "Numéro", Prompt = "Entrez votre numéro ici")]
        public int Numero { get; set; }

        [Display(Name = "Nom", Prompt = "Entrez votre nom ici")]
        public string Nom { get; set; }

        [Display(Name = "Prénom", Prompt = "Entrez votre prénom ici")]
        public string Prenom { get; set; }

        [Display(Name = "Date de naissance", Prompt = "Entrez votre date de naissance ici")]
        public DateTime DateNaissance { get; set; }

        [Display(Name = "Tél.", Prompt = "Entrez votre numéro de téléphone ici")]
        public string Telephone { get; set; }
    }
}
