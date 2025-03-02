using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Etudiant.Models
{
    internal class Classe
    {

        public int Id { get; set; }
        public string NomClasse { get; set; }
        public virtual ICollection<Etudiant> Etudiants { get; set; } // Relation 1:N avec Étudiant
        public virtual ICollection<Professeur> Professeurs { get; set; } // Relation N:N avec Professeur
        public virtual ICollection<Cours> Cours { get; set; } // Relation N:N avec Cours


    }
}
