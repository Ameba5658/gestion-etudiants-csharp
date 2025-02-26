using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace projetgestionsEtudiant.Models
{
    internal class Cours
    {
        public int Id { get; set; }
        public string NomCours { get; set; }
        public string Description { get; set; }

        // Relation avec Classes
        public virtual ICollection<Classe> Classes { get; set; }
    }

}

