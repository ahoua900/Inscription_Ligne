using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inscription_Ligne.Models
{
    public class Etablissement
    {
        public int IdEtablissment { get; set; }
        public string Nom_Etablissment { get; set; }
        public int Code_Etablissment { get; set; }
        public string Localité_Etablissment { get; set; }
        public string Email_Etablissment { get; set; }
        public string Attestation_Etablissment { get; set; }
        public string Type_Etablissment { get; set; }
        public int Enseignement_Etablissment { get; set; }
        public string Statut_Etablissment { get; set; }
        public int Scolarité_Etablissment { get; set; }
        public List<Niveau> Niveaus { get; set; }
        public int IdNiveau { get; set; }
        public List<Eleves> Eleves { get; set; }
        public int IdEleve { get; set; }
    }
}