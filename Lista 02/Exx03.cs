using System;//biblioteca .net

class Program { 
  public static void Main () {
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina: \n");
    int n1;
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota do segundo bimestre da disciplina: \n");
    int n2;
    n2 = int.Parse(Console.ReadLine());

    int media_parcial = ((n1 * 2) + (n2 * 3)) / 5;
    Console.WriteLine($"Media parcial = {media_parcial}");
  }
}