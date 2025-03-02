using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Etudiant.Models
{
    internal class Etudiant
    {

        public int Id { get; set; }
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Sexe { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int ClasseId { get; set; } // Clé étrangère vers Classe
        public virtual Classe Classes { get; set; } // Relation N:1 avec Classe
        public virtual ICollection<Note> Notes { get; set; } // Relation 1:N avec Note

    }
}
