using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace projetgestionsEtudiant.Models
{
   

    internal class Matiere
    {
        public int Id { get; set; }
        public string NomMatiere { get; set; }

        // Relation avec Classes
        public virtual ICollection<Classe> Classes { get; set; }
        public override string ToString()
        {
            return NomMatiere;  // Assurez-vous que "Nom" est bien un attribut existant dans la classe Matiere
        }

    }



}
