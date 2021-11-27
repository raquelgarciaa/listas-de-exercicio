using System;//biblioteca .net

class Program { 
  public static void Main () {
    Console.WriteLine("Escreva dois valores: ");
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    Console.WriteLine($"O maior valor é : {Maior(x,y):0.00}");

}

  public static double Maior(double x, double y){
    if(x>y){
      return x;
    }
  return y;
  }
}