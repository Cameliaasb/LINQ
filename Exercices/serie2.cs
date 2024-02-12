using System.Diagnostics.Contracts;
using System.Net;

public class serie2
{
  public static List<Dog> dogs = new List<Dog> {
    new Dog("Berger Australien", "Banzaï", 1, 28),
    new Dog("Berger Australien", "Letto", 3, 30),
    new Dog("Berger Australien", "Princesse", 8, 32),
    new Dog("Berger Allemand", "Floyd", 10, 32),
    new Dog("Caniche", "Igor", 13, 9),
    new Dog("Labrador", "Swing", 15, 25),
    new Dog("Teckel", "Wonki", 2, 5),
    new Dog("Terre Neuve", "Albator", 1, 50),
    new Dog("Carlin", "Pataud", 13, 10),
    new Dog("Boxer", "Frank", 6, 25),
    new Dog("Lévrier Afghan", "Précieuse", 9, 26),
    new Dog("Yorkshire", "Kakou", 3, 6)

  };

  public class Dog
    {
      public string Race{get ; set ;}
      public string Name{get ; set ;}
      public int Age{get ;set ; }
      public int Weight{get ;set ;}
      public Dog(string race, string name, int age, int weight){
          Race = race;
          Name = name;
          Age = age;
          Weight = weight;
      }
    }


  public static void Exo() {
    var query_1 = dogs.Where(dog => dog.Race == "Berger Australien");
    var query_2 = query_1.OrderBy(dog => dog.Name);

    var query_3 = dogs.Where(dog =>
      dog.Name.Length > 5 && dog.Age > 5);
    var query_4 = query_3.OrderBy(dog => dog.Weight);

    var query_5 = dogs.OrderByDescending(dog => dog.Age).OrderBy(dog => dog.Weight);

    var query_6 = dogs.Where(dog =>
      !dog.Race.Contains(" ") &&  dog.Weight > 15
      && dog.Name.Contains("i")).OrderBy(dog => dog.Name.Length);


    showDogs(1, query_1);
    showDogs(2, query_2);
    showDogs(3, query_3);
    showDogs(4, query_4);
    showDogs(5, query_5);
    showDogs(6, query_6);
  }


  public static void showDogs(int i, IEnumerable<Dog> dogs ) {
    Console.Write($"\n{i} : ");

    foreach (var dog in dogs)
    {
      Console.Write(dog.Name + " ");
    }
  }
}
