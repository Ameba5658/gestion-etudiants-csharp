using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Etudiant.Models
{
    internal class Utilisateur
    {

        public int Id { get; set; } // Clé primaire
        public string NomUtilisateur { get; set; }
        public string MotDePasse { get; set; } // À hasher avant de stocker
        public string Role { get; set; } // "Administrateur", "DE", "Agent", "Professeur"
        public string Telephone { get; set; } // Pour l'A2F par SMS
        public bool Active { get; set; } // Pour savoir si l'utilisateur est authentifié
        public DateTime? OtpExpiration { get; set; } // Date d'expiration de l'OTP, nullable pour l'absence d'OTP
        public virtual ICollection<OTPCode> OTPCodes { get; set; } // Relation 1:N avec OTPCode

    }
}