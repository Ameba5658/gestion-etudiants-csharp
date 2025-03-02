using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Etudiant.Models
{
    internal class Matiere
    {

        public int Id { get; set; } // Clé primaire
        public string NomMatiere { get; set; }
        public virtual ICollection<Cours> Cours { get; set; } // Relation N:N avec Cours (via CoursMatières)
        public virtual ICollection<Professeur> Professeurs { get; set; } // Relation N:N avec Professeur (via ProfesseursMatières)
        public virtual ICollection<Note> Notes { get; set; } // Relation 1:N avec Note

    }
}