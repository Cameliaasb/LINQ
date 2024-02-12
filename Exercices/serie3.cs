class serie3 {

  class Personne{
        public string Nom{ get ; set ; }
        public string Prenom{get ; set ;}
        public bool Est_ingenieur{get ; set ; }
        public Personne(string nom, string prenom, bool ingenieur)
        {
            Nom = nom;
            Prenom = prenom;
            Est_ingenieur = ingenieur;
        }
    }
    class Ingenieur {
        public string Nom{get ; set ; }
        public string Prenom{get ; set ;}
        public string Specialite{get ; set ; }
        public Ingenieur(string nom, string prenom){
            Nom = nom;
            Prenom = prenom;
        }
        public Ingenieur(string nom, string prenom, string specialite){
            Nom = nom;
            Prenom = prenom;
            Specialite = specialite;
        }
    }


  class Technicien{
    public string Nom{get ; set ;}
    public string Prenom{get ; set ;}
    public Technicien(string nom, string prenom){
      Nom = nom;
      Prenom = prenom; }
  }

  static List<Personne> personnes = new List<Personne> { new Personne("Hallyday", "Johnny", false), new Personne("Vartan", "Sylvie", false),
  new Personne("Drucker", "Michel", false), new Personne("Antoine", "Antoine", true), new Personne("Philippe", "Edouard", false), new Personne("Demorand", "Patricia", true), new Personne("Ulysse", "Margareth", true), new Personne("Zenith", "Méryl", true),
  new Personne("Bobo", "Jojo", false) };





  public static void showIngenieurs() {
    var ingenieurs = personnes.Where(personne => personne.Est_ingenieur).OrderBy(pers => pers.Nom).ThenBy(pers => pers.Prenom);
    Console.WriteLine("Les ingénieurs : ");
    foreach (var p in ingenieurs)
    {
      Console.WriteLine($"{p.Prenom} {p.Nom}");
    }
  }

  public static void showTechniciens() {
      var techniciens = personnes.Where(personne => !personne.Est_ingenieur);
      Console.WriteLine("Les techniciens : ");
      foreach (var p in techniciens)
      {
        Console.WriteLine($"{p.Prenom} {p.Nom}");
      }
  }

}
