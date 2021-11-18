using System;//biblioteca .net

class Program { 
  public static void Main () {
    double hours = double.Parse(Console.ReadLine());
    double km = double.Parse(Console.ReadLine());

    Console.WriteLine($"{(hours*km) /12:0.000}");

}
}