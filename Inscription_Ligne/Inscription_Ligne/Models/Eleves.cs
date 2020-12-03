using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inscription_Ligne.Models
{
    public class Eleves
    {
        [Key]
        public int MyProperty { get; set; }
        public string Nom_Eleve { get; set; }
        public string Prenom_Eleve { get; set; }
        public int Matricule_Eleve { get; set; }
        public string Classe_Eleve { get; set; }
        public string Email_Parent  { get; set; }
        public int Contact_Parent  { get; set; }
        public string Extrait_naissance { get; set; }
        public string Photo { get; set; }
        public string Etablissement { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}