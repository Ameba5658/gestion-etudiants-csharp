using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Etudiant.Models
{
    internal class OTPCode
    {

        public int Id { get; set; } // Clé primaire
        public string Code { get; set; } // Code OTP
        public DateTime DateExpiration { get; set; } // Date d'expiration du code
        public int UtilisateurId { get; set; } // Clé étrangère vers Utilisateur
        public virtual Utilisateur Utilisateur { get; set; } // Relation N:1 avec Utilisateur

    }
}
