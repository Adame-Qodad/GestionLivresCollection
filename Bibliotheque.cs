using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLivresCollection
{
    class Bibliotheque
    {
        private string nomBiblio;
        List<Livre> listeLivre = new List<Livre>();
        public string NomBiblio { get => nomBiblio; set => nomBiblio = value; }

        public Bibliotheque(string nom)
        {   this.nomBiblio = nom;   }
        public int Cardinal()
        { return this.listeLivre.Count; }
        public void Ajouter(Livre l)
        {   this.listeLivre.Add(l);  }
        public override string ToString()
        { StringBuilder sb = new StringBuilder();
                sb.AppendLine("La bibliothèque " + this.NomBiblio + " contients les livres:\n"); 
                foreach (Livre livre in this.listeLivre) { sb.AppendLine(livre.ToString()); }
            return sb.ToString();        
        }
        public void AfficheAuteur(string a)
        { foreach (Livre livre in this.listeLivre)
            { if (livre.AutLivre == a)  { Console.WriteLine(livre); }   }
        }
        public void LivreExiste(string t)
        {
            foreach (Livre livre in this.listeLivre)
            { if (livre.TitreLivre == t) { Console.WriteLine(livre); } }
        }
        public void AfficheEditeur(string e)
        {
            foreach (Livre livre in this.listeLivre)
            { if (livre.EdLivre == e) { Console.WriteLine(livre); } }
        }
        public bool SupprimerLivre(string t)
        {
            foreach (Livre livre in this.listeLivre)
            { if (livre.TitreLivre == t) { listeLivre.Remove(livre); return true; } }
            return false;
        }
        public bool SupprimerLivreAuteur(string a)
        {
            foreach (Livre livre in this.listeLivre)
            { if (livre.AutLivre == a) { listeLivre.Remove(livre); return true; } }
            return false;
            
        }


    }
}
