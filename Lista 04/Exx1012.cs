using System;//biblioteca .net

class Program { 
  public static void Main () {
    string s = Console.ReadLine();
    string[] w = s.Split(' ');

    double a = double.Parse(w[0]);
    double b = double.Parse(w[1]);
    double c = double.Parse(w[2]);

    Console.WriteLine($"TRIANGULO: {a*c/2:0.000}");
    Console.WriteLine($"CIRCULO: {3.14159*c*c:0.000}");
    Console.WriteLine($"TRAPEZIO: {((a+b)*c) /2:0.000}");
    Console.WriteLine($"QUADRADO: {b*b:0.000}");
    Console.WriteLine($"RETANGULO: {a*b:0.000}");
    

}
}