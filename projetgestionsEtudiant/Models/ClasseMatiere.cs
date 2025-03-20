using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetgestionsEtudiant.Models
{
    internal class ClasseMatiere
    {
        public int Id { get; set; }
        public int ClasseId { get; set; }
        public int MatiereId { get; set; }

        public virtual Classe Classe { get; set; }
        public virtual Matiere Matiere { get; set; }
    }
}
