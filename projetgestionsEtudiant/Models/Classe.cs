using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace projetgestionsEtudiant.Models
{

    internal class Classe
    {
        public int Id { get; set; }
        public string NomClasse { get; set; }

        // Relation avec Cours et Matières
        public virtual ICollection<Cours> Cours { get; set; }
        public virtual ICollection<Matiere> Matieres { get; set; }

        public override string ToString()
        {
            return NomClasse;  // Assurez-vous que "Libelle" est bien un attribut existant dans la classe Classe
        }

    }
}
