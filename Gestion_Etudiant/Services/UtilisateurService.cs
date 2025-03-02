using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Etudiant.Donnes;
using Gestion_Etudiant.Models;

namespace Gestion_Etudiant.Services
{
    internal class UtilisateurService
    {

        // Ajouter un utilisateur
        public void AjouterUtilisateur(Utilisateur utilisateur)
        {
            using (var context = new DbGestionContext())
            {
                context.Utilisateurs.Add(utilisateur);
                context.SaveChanges();
            }
        }

        // Modifier un utilisateur
        public void ModifierUtilisateur(int id, Utilisateur utilisateurModifie)
        {
            using (var context = new DbGestionContext())
            {
                var utilisateur = context.Utilisateurs.Find(id);
                if (utilisateur != null)
                {
                    utilisateur.NomUtilisateur = utilisateurModifie.NomUtilisateur;
                    utilisateur.MotDePasse = utilisateurModifie.MotDePasse;
                    utilisateur.Role = utilisateurModifie.Role;
                    utilisateur.Telephone = utilisateurModifie.Telephone;
                    utilisateur.Active = utilisateurModifie.Active;
                    utilisateur.OtpExpiration = utilisateurModifie.OtpExpiration;
                    context.SaveChanges();
                }
            }
        }

        // Supprimer un utilisateur
        public void SupprimerUtilisateur(int id)
        {
            using (var context = new DbGestionContext())
            {
                var utilisateur = context.Utilisateurs.Find(id);
                if (utilisateur != null)
                {
                    context.Utilisateurs.Remove(utilisateur);
                    context.SaveChanges();
                }
            }
        }

        // Lister les utilisateurs
        public List<Utilisateur> ListerUtilisateurs()
        {
            using (var context = new DbGestionContext())
            {
                return context.Utilisateurs.ToList();
            }
        }
    }
}
 



