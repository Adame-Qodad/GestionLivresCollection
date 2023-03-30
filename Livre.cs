using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GestionLivresCollection
{
    class Livre
    {
        private string codeLivre;
        private string titreLivre;
        private string edLivre;
        private string autLivre;
        private int anLivre;


        public string CodeLivre { get => codeLivre; set => codeLivre = value; }
        public string TitreLivre { get => titreLivre; set => titreLivre = value; }
        public string EdLivre { get => edLivre; set => edLivre = value; }
        public string AutLivre { get => autLivre; set => autLivre = value; }
        public int AnLivre { get => anLivre; set => anLivre = value; }

        public Livre(string code, string titre, string editeur, string auteur, int annee)
        {
            this.CodeLivre = code;
            this.TitreLivre = titre;
            this.EdLivre = editeur;
            this.AutLivre = auteur;
            this.AnLivre = annee;
        }
        public override string ToString()
        {
            return "Le livre " + this.TitreLivre + " est sortie en " + this.AnLivre + ", il a été écrit par " + this.AutLivre + " sortie par l'éditeur " + this.EdLivre + ". Son code est: " + this.CodeLivre;
        }






    }
}
