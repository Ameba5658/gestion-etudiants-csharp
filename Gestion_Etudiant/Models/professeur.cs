using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Etudiant.Models
{
    internal class Professeur
    {

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public virtual ICollection<Matiere> Matieres { get; set; } // Relation N:N avec Matière
        public virtual ICollection<Classe> Classes { get; set; } // Relation N:N avec Classe


    }
}
