using System.Runtime.CompilerServices;

public class serie6 {
  class Personne{
    public string Nom{ get ; set ; }
    public string Prenom{get ; set ;} public int Age{ get ; set ; }
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
  }

  static List<Personne> personnes = new List<Personne>()
            {
                new Personne("Garett", "Ramzy", 45, "M"),
                new Personne("Caire", "Joe", 35, "M"),
                new Personne("Clay", "Alicia", 18, "F"),
                new Personne("Bavette", "Simone", 68, "F"),
                new Personne("Henry", "Thierry", 44, "M"),
                new Personne("Jacquesonne", "Janett", 25, "F"),
                new Personne("Buveur", "Joe", 25, "M"),
                new Personne("Louet", "Karim", 31, "M"),
                new Personne("Louette", "Karima", 31, "F"),
                new Personne("Caire", "Paul", 19, "M"),
                new Personne("Mille", "Camille", 20, "F"),
                new Personne("Cent", "Camille", 40, "F"),
                new Personne("Million", "Camille", 60, "M"),
                new Personne("Gold", "Roger", 17, "M"),
                new Personne("Lion", "Sandra", 8, "F"),
                new Personne("René", "Jean", 6, "M")
            };


  static public void exo_11() {
    var query_1 = personnes.GroupBy(p => p.Sexe);

    foreach (IGrouping<string, Personne> group in query_1)
    {
        Console.WriteLine("\n"+group.Key);
        foreach (var p in group)
        {
          Console.WriteLine($"{p.Nom}");
        }
    }
  }

  static public void exo_12() {
    var query_1 = personnes.GroupBy(p => p.Age);
    foreach (var group in query_1)
    {
      Console.WriteLine($"\n{group.Key}");
      var subgroup = group.OrderBy(p => p.Age);
      foreach (var p in subgroup)
      {
        Console.WriteLine($"{p.Nom} - {p.Age} ans");
      }
    }
  }

    static public void exo_13() {
    var query_1 = personnes.Where(p=> p.Age > 18).GroupBy(p => p.Prenom);
    foreach (var group in query_1)
    {
      Console.WriteLine($"\nPrénom : {group.Key}");
      var subgroup = group.OrderByDescending(p => p.Nom);
      foreach (var p in subgroup)
      {
        Console.WriteLine($"{p.Nom}");
      }
    }
  }


  static List<int> nombres = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20, 11, 13, 12, 14, 18, 17, 16, 14, 14 };

  static public void exo_21(){
    var groups = nombres.Select( n => new {nb = n, pair = (n % 2 == 0)} ).GroupBy(p=> p.pair);
    foreach (var group in groups)
    {
      Console.WriteLine(group.Key ? "Pair" : "Impair");
      var subgroup = group.Select(n => n);
      foreach (var n in subgroup)
      {
        Console.WriteLine(n.nb);
      }
    }
  }

}
