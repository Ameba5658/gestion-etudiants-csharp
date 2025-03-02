using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Etudiant.Models
{
    internal class Note
    {

        public int Id { get; set; } // Clé primaire
        public float Valeur { get; set; } // Note de l'étudiant
        public int EtudiantId { get; set; } // Clé étrangère vers Étudiant
        public int MatiereId { get; set; } // Clé étrangère vers Matière
        public virtual Etudiant Etudiants { get; set; } // Relation N:1 avec Étudiant
        public virtual Matiere Matieres { get; set; } // Relation N:1 avec Matière

    }
}