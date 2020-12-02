using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inscription_Ligne.Models
{
    public class Niveau
    {
        public int IdNiveau { get; set; }
        public string  Nom_Niveau { get; set; }
        public string  Montant_Affecte { get; set; }
        public string Montant_NonAffecte { get; set; }
        
    }
}