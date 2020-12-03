using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inscription_Ligne.Models
{
    public class Connexion
    {
        public Etablissement Etablissement { get; set; }
        public Eleves Eleves { get; set; }
        
    }
}