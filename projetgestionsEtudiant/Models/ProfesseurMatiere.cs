using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetgestionsEtudiant.Models
{
    internal class ProfesseurMatiere
    {
        public int Id { get; set; }

        // Clé étrangère vers Professeur
        public int ProfesseurId { get; set; }
        public virtual Professeur Professeur { get; set; }

        // Clé étrangère vers Matière
        public int MatiereId { get; set; }
        public virtual Matiere Matiere { get; set; }
    }
}
