using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetgestionsEtudiant.Models
{
    internal class ClasseCours
    {
        public int Id { get; set; }
        public int ClasseId { get; set; }
        public int CoursId { get; set; }

        public virtual Classe Classe { get; set; }
        public virtual Cours Cours { get; set; }


    }

    
}

