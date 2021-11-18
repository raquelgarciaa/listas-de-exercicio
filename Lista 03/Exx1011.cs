using System;//biblioteca .net

class Program { 
  public static void Main () {
    double r = double.Parse(Console.ReadLine());
    double pi = 3.14159;

    double volume = 4.0/3*pi*r*r*r;
    Console.WriteLine($"VOLUME = {volume:0.000}");
  }
}
