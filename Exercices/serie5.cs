using System.Security.Cryptography;

public class serie5 {

  class Personne {
    public string Nom{ get ; set ; }
    public string Prenom{get ; set ;}
    public int Age{ get ; set ; }
    public string Sexe{get ; set ;}
    public bool Est_ingenieur{get ; set ; }
    public Personne(string nom, string prenom, bool ingenieur = false) {
      Nom = nom;
      Prenom = prenom;
      Est_ingenieur = ingenieur;
    }
    public Personne(string nom, string prenom, int age, string sexe) {
      Nom = nom;
      Prenom = prenom;
      Age = age;
      Sexe = sexe;
    }
    public Personne(string nom, string prenom, int age, string sexe, bool ingenieur){
      Nom = nom;
      Prenom = prenom;
      Age = age;
      Sexe = sexe;
      Est_ingenieur = ingenieur;
    }

  }

  static List<List<Personne>> personnes = new List<List<Personne>>
    {
      new List<Personne>() {new ("Drucker", "Michel"),
                            new ("Bedia", "Ramzy"),
                            new ("Judor", "Eric")},

      new List<Personne>() {new ("Diaz", "Cameron"),
                            new ("Depardieu", "Gerard"),
                            new ("Stallone", "Sylvester"),
                            new ("Macron", "Emmanuel")},

      new List<Personne>() {new ("Benzema", "Karim"),
                            new ("Antoine", "Eric"),
                            new ("Ruiz", "Olivia"),
                            new ("Clavier", "Christian"),
                            new ("Einstein", "Albert")}
    };


    public static void exo_1() {
      Console.WriteLine("\nEXO 1 ");
      var query_1 =  personnes.SelectMany(p => p).Where(p => p.Nom.Length > 5);
      foreach (var item in query_1)
      {
        Console.WriteLine(item.Nom);
      }
    }

    public static void exo_2 ()
    {
      Console.WriteLine("\nEXO 2 ");
      var query_2 = personnes.SelectMany(p => p)
                    .Where(p => p.Nom.Contains("e") && p.Prenom.Contains("a"))
                    .OrderByDescending(p => p.Nom)
                    .Select(p => new {
                      identite = $"{p.Prenom} {p.Nom}"
                    }
      );

      foreach (var p in query_2)
      {
        Console.WriteLine($"{p.identite}");
      }
    }

}
