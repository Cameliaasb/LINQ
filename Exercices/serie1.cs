using System.Runtime.CompilerServices;

public class serie1
{

  static void showInts(int i, IEnumerable<int> list ){
    Console.Write($"\n{i} : ");
    foreach (var item in list)
    {
      Console.Write(item + " ");
    }
  }

  static void showStrings(int i, IEnumerable<string> list ){
    Console.Write($"\n{i} : ");
    foreach (var item in list)
    {
      Console.Write(item + " ");
    }
  }
  public static void exercice_1 () {
    Console.WriteLine("-------EXERCICE 1---------");
    List<int> entiers = new List<int> {4,5,2,3,1,1,0,5,8,9,10,15,16,20,21,4,5};

    var query_11 = entiers.Where(entier => entier > 5).ToList();
    var query_12 = entiers.Where(entier => entier >= 5 && entier < 20).ToList();
    var query_13 = entiers.Where(
      entier => entier > 2  && (entier % 2 == 0)
      && entier < 20  && entier != 8).ToList();

    showInts(1, query_11);
    showInts(2, query_12);
    showInts(3, query_13);
  }

  public static void exercice_2() {
    Console.WriteLine("\n\n-------EXERCICE 2---------");
    List<string> fruits = new List<string> {"Banane", "Ananas", "Cerise", "Framboise", "Groseilles",
    "Pomme", "Poire", "Tomate", "Kiwi", "Raisin", "Mangue", "Datte"};


    var query_21 = fruits.Where(fruit => fruit.Length > 5);
    var query_22 = fruits.Where(
      fruit => fruit.Length > 4 && fruit.StartsWith("P")
      && fruit.Contains("o") && !fruit.Contains("m")
    );

    var query_23 = fruits.OrderBy(fruit => fruit.Length);

    showStrings(1, query_21);
    showStrings(2, query_22);
    showStrings(3, query_23);
  }

}
