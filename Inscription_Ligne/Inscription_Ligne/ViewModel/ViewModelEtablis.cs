using Inscription_Ligne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inscription_Ligne.ViewModel
{
    public class ViewModelEtablis
    {
        public List<Etablissement> Etablissement { get; set; }
        public List<Niveau> Niveau { get; set; }
        public List<Eleves> Eleves { get; set; }
    }
}