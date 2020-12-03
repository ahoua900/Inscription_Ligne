using System;
using System.Collections.Generic;
using System.Linq;
using Inscription_Ligne.Models;
using System.Web;

namespace Inscription_Ligne.ViewModel
{
    public class ViewModelEleves
    {
        public Etablissement Etablissement { get; set; }
        public Niveau Niveau { get; set; }
        public List<Eleves> Eleves { get; set; }
    }
}