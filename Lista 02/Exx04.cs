using System;//biblioteca .net

class Program { 
  public static void Main () {
    //inserir
    Console.WriteLine("Digite a base e a altura do retângulo \n");
    int al, b;
    al = int.Parse(Console.ReadLine());
    b =  int.Parse(Console.ReadLine());
    //contas
    double area = b * al;
    double perimetro = (b*2) + (al*2);
    double diagonal = Math.Sqrt((b*b) + (al*al));
    //mostrar
    Console.WriteLine($"Área = {area:0.00} - Perímetro = {perimetro:0.00} - Diagonal = {diagonal:0.00}");

  }
}