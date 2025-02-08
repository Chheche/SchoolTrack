using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDevTest.Classes
{
    public class Enfant
    {
        public int id_enfant { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string date_naissance { get; set; }
        public string sexe { get; set; }
        public string lieu_naissance { get; set; }
        public string code_postal { get; set; }
        public string adresse { get; set; }
        public string classe_inscription { get; set; }
    }
}
