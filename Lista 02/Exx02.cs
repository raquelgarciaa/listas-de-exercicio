using System;//biblioteca .net

class Program { 
  public static void Main () {
    string name;
    Console.WriteLine("Digite seu nome:\n");
    name = Console.ReadLine();

    int found = 0;
    found = name.IndexOf(" "); //index
    //name.IndexOf(" ", found)

    Console.WriteLine($"Bem-vindo ao C#, {name.Substring(0, found)}"); //inicio - fim
  }
}