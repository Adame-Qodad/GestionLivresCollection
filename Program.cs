using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLivresCollection
{
     class Program
    {
        static void Main(string[] args)
        {
            Bibliotheque bi = new Bibliotheque("Gutenberg");
            bi.Ajouter(new Livre("L1", "Quatre vingt treize", "Dunoid", "Victor Hugo", 1870));
            bi.Ajouter(new Livre("L2", "Les Misérables", "Folio", "Victor Hugo", 1873));
            bi.Ajouter(new Livre("L3", "l'âme du mal", "Poche", "Maxime Chatam", 2005));
            bi.Ajouter(new Livre("L4", "Desert", "Folio", "Le Clezio", 1980));
            bi.Ajouter(new Livre("L5", "Diégo et Frieda", "Poche", "Le Clezio", 1975));

            Console.WriteLine(bi);
            Console.ReadKey();
            bi.AfficheAuteur("Victor Hugo");
            Console.ReadKey();
            bi.AfficheEditeur("Poche");
            Console.ReadKey();
            bi.SupprimerLivre("Desert");
            Console.WriteLine(bi);
            Console.ReadKey();
            bi.SupprimerLivreAuteur("Victor Hugo");
            Console.WriteLine(bi);
            Console.ReadKey();
        
        }
    }
}