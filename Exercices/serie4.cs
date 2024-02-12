using System.ComponentModel.Design;
using System.Security.Cryptography;

class serie4 {
  class Personne{
    public string Nom{ get ; set ; }
    public string Prenom{get ; set ;}
    public int Age{ get ; set ; }
    public string Sexe{get ; set ;}
    public bool Est_ingenieur{get ; set ; }
    public Personne(string nom, string prenom, bool ingenieur) { Nom = nom;
      Prenom = prenom;
      Est_ingenieur = ingenieur; }
    public Personne(string nom, string prenom, int age, string sexe) { Nom = nom;
      Prenom = prenom;
      Age = age;
      Sexe = sexe; }
    public Personne(string nom, string prenom, int age, string sexe, bool ingenieur){ Nom = nom;
      Prenom = prenom;
      Age = age;
      Sexe = sexe;
      Est_ingenieur = ingenieur; }

    public string nom_complet() {
      return $"{Prenom} {Nom}";
    }


    public string initiales() {
      return $"{Prenom[0]}.{Nom[0]}";
    }


  }


  static List<Personne> personnes = new List<Personne> {
    new Personne("Beauvoir", "Simon", 16, "M"), new Personne("Beauvoir", "Simone", 25, "F"), new Personne("De Caunes", "Richard", 41, "M"), new Personne("Sullivan", "Sullivan", 31, "M"), new Personne("Rémy", "Camille", 22, "F"),
    new Personne("Manchon", "Camille", 19, "M"), new Personne("Thiebaud", "Marie", 61, "F"), new Personne("Crouchon", "Mélanie", 55, "F"), new Personne("Baline", "Mélodie", 74, "F"), new Personne("Karine", "Pascal", 31, "M"), new Personne("Katherine", "Pascale", 36, "F"), new Personne("Zoula", "Charles", 20, "M"), new Personne("Romain", "Collin", 34, "M"), new Personne("Fouchard", "Aïcha", 48, "F"), new Personne("Blandine", "Maëva", 18, "F")
  };

  // static public void nom_age() {
  //   foreach (var p in personnes)
  //   {
  //     Console.WriteLine($"{p.nom_complet()}, {p.Age}ans");
  //   }
  // }


  static public void exo_1 () {
    var query1 = from personne in personnes
                select new { nom_prenom = personne.nom_complet(), age = personne.Age};

    foreach (var p in query1)
    {
      Console.WriteLine($"{p.nom_prenom}, {p.age}");
    }
  }

  static public void exo_2() {
    var query2  = from p in personnes
                  where p.Age > 18 && p.Age <= 50
                  select new {
                    nom = p.Nom,
                    prenom = p.Prenom,
                    initiales = p.initiales(),
                    taille_nom_complet = p.Nom.Length + p.Prenom.Length,
                    age = p.Age };

    foreach (var p in query2)
    {
      Console.WriteLine($"{p.initiales} - {p.taille_nom_complet} lettres - {p.age}ans" );
    }
  }

}
