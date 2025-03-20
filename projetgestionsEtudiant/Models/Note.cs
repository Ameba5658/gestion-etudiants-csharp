using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetgestionsEtudiant.Models
{
    internal class Note
    {
        public int Id { get; set; }

        // Clé étrangère vers l'étudiant
        public int EtudiantId { get; set; }
        public virtual Etudiant Etudiant { get; set; }

        // Clé étrangère vers la matière
        public int MatiereId { get; set; }
        public virtual Matiere Matiere { get; set; }

        // Valeur de la note
        public float Valeur { get; set; }
    }
}
