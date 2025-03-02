using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Etudiant.Models
{
    internal class Cours
    {

        public int Id { get; set; } // Clé primaire
        public string NomCours { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Classe> Classes { get; set; } // Relation N:N avec Classe (via ClassesCours)
        public virtual ICollection<Matiere> Matieres { get; set; } // Relation N:N avec Matière (via CoursMatières)

    }
}
