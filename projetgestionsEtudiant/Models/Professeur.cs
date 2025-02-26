using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetgestionsEtudiant.Models
{
    internal class Professeur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        // Relation avec Matières et Classes
        public virtual ICollection<Matiere> Matieres { get; set; }
        public virtual ICollection<Classe> Classes { get; set; }
    }
}
