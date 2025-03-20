using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetgestionsEtudiant.Models
{
    public class Utilisateur
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nom { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public string MotDePasse { get; set; } // Stocke un mot de passe haché

        [Required, MaxLength(20)]
        public string NumeroTelephone { get; set; }

        [Required]
        public string Role { get; set; }  // "Administrateur", "DE", "Agent", "Professeur"

        public bool EstActive { get; set; } = false; // L'utilisateur doit activer son compte

        public string CodeValidation { get; set; } // Code de validation envoyé par SMS
    }
}