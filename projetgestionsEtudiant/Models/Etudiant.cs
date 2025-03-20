using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetgestionsEtudiant.Models
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

    // Clé étrangère vers la classe
    public int ClasseId { get; set; }
    public virtual Classe Classe { get; set; }

        // 📌 Ajouter le champ pour stocker la moyenne générale
        public float? MoyenneGenerale { get; set; } // ✅ Correct (permet null)


    }
}
