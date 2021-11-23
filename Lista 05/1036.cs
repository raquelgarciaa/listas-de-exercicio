using System;//biblioteca .net

class Program { 
  public static void Main () {
    string values = Console.ReadLine();
    string[] x =values.Split(' ');

    double a = double.Parse(x[0]);
    double b = double.Parse(x[1]);
    double c = double.Parse(x[2]);

    double delta = (b*b) - (4*a*c);
    if(a==0 || b==0 || c==0 || delta<0){
      Console.WriteLine("Impossivel calcular");
    }
    else{
    Console.WriteLine($"R1 = {(-b + Math.Sqrt(delta)) / (2*a):0.00000}");
    Console.WriteLine($"R2 = {(-b - Math.Sqrt(delta)) / (2*a):0.00000}");
    }

}
}