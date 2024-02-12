using Microsoft.VisualBasic;

public class serie7 {
   class Chien{
      public string Nom{get ;set ;}
      public string Surnom{get ;set ;}
      public string Race{get ;set ;}
      public string Couleur{get ;set ;}
      public string Sexe{get ;set ;}
      public int Age{get ;set ;}
      public int Poids{get ;set ;}
      public Chien(string nom, string surnom, string race, string couleur, string sexe, int age, int poids)
        {
            this.Nom = nom;
            this.Surnom = surnom;
            this.Race = race;
            this.Couleur = couleur;
            this.Sexe = sexe;
            this.Age = age;
            this.Poids = poids;
        }
    }


    static List<Chien> chiens = new List<Chien>()
      {
          new Chien("Gnocci", "Gnoc Gnoc", "Labrador", "Sable", "M", 1, 20),
          new Chien("Vagabond", "Gros Loup", "Labrador", "Noir", "M", 8, 25),
          new Chien("Milou", "Milos", "Labrador", "Sable", "M", 10, 24),
          new Chien("Sirène", "Sissy", "Labrador", "Sable","F", 4, 19),
          new Chien("Félicia", "Felicci", "Labrador", "Sable", "F", 6, 20),
          new Chien("Kratos", "Mon tueur", "Chihuahua", "Fauve", "M", 1, 2),
          new Chien("Jack", "Jaja", "Chihuahua", "Fauve", "M", 1, 2),
          new Chien("Mojave", "Mojojo", "Chihuahua", "Fauve", "M", 1, 2),
          new Chien("Hercule", "Herc", "Chihuahua", "Beige", "M", 35, 2),
          new Chien("Médusa", "Med", "Terre-Neuve", "Noire", "F", 6, 40),
          new Chien("Mélusine", "Mel", "Terre-Neuve", "Noire", "F", 7, 41),
          new Chien("Venus", "Violette", "Terre-Neuve", "Noire", "F", 8, 38),
          new Chien("Letto", "Lele", "Berger Australien", "Bleu Merle", "M", 3, 30),
          new Chien("Cabron", "Dum dum", "Berger Australien", "Bleu Merle", "M", 9, 31),
          new Chien("Banzaï", "Zaïzaï", "Berger Australien", "Noir et blanc", "M", 1, 28 ),
          new Chien("Haricot", "Harry", "Berger Australien", "Noir et blanc", "M", 2, 27),
          new Chien("Gédéon", "Gégé", "Berger Allemand", "Noir et feu", "M", 9, 31),
          new Chien("Bella", "Belbel", "Berger Allemand", "Noir et feu", "F", 5, 28),
          new Chien("Oui-oui", "oui", "Berger Allemand", "Sable", "M", 7, 35),
          new Chien("Pataud", "Patoche", "Carlin", "Sable", "M", 16, 8),
          new Chien("Killer", "Kiki", "Carlin", "Sable", "M", 10, 8),
          new Chien("Frank", "Colonel", "Carlin", "Noir", "M", 9, 9)
      };

    public static void  exo_1(){
      var parRace = chiens.GroupBy(c => c.Race).OrderBy(col => col.Key);
      foreach (var groupe in parRace)
      {
        groupe.GroupBy(c => c.Couleur);
      }

      foreach (var groupe in parRace)
      {
        Console.WriteLine(groupe.Key);
        foreach (var dog in groupe)
        {
          Console.WriteLine($"{dog.Surnom}, {dog.Couleur}");
        }
      }
    }


    public static void exo_2() {
      var parCouleur = chiens.GroupBy(c => c.Couleur);
      foreach(var couleur in parCouleur) {
        var parSexe = couleur.GroupBy(c => c.Sexe).OrderBy(col => col.Key);

        Console.WriteLine($"\n{couleur.Key}");
        foreach (var sexe in parSexe)
        {
          Console.WriteLine($"Sexe : {sexe.Key}");
          foreach (var dog in sexe)
          {
            Console.WriteLine(dog.Nom);
          }

        }
      }
    }


// Ecrire les requêtes LINQ permettant de :
// 1. Faire un group by multiple sur la race et la couleur et trier par race, puis par couleur (ordre
// croissant)
// 2. Faire un group by multiple sur la couleur et le sexe et faire un tri croissant sur le sexe.
// 3. Faire un group by par sexe, age, couleur
// • Pour les chiens âgés entre 2 et 15 ans (inclus)
// • Sélectionner les chiens dont le surnom n'est pas un nom composé (on cherche les surnoms
// sans espace)
// • Trier par sexe (croissant), par âge (décroissant), par race (décroissant), par couleur (croissant)

}
