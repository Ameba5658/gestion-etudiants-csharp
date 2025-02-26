using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetgestionsEtudiant.Models
{
    internal class ProfesseurClasse
    {
        public int Id { get; set; }

        // Clé étrangère vers Professeur
        public int ProfesseurId { get; set; }
        public virtual Professeur Professeur { get; set; }

        // Clé étrangère vers Classe
        public int ClasseId { get; set; }
        public virtual Classe Classe { get; set; }
    }
}
