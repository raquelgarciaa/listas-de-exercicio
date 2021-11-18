using System;//biblioteca .net

class Program { 
  public static void Main () {
    string total_1 = Console.ReadLine();
    string total_2 = Console.ReadLine();

    string[] a= total_1.Split(' ');
    double x1 = double.Parse(a[0]);
    double y1 = double.Parse(a[1]);
    
    string[] b= total_2.Split(' ');
    double x2 = double.Parse(b[0]);
    double y2 = double.Parse(b[1]);

    double x = x2 -x1;
    double y = y2 -y1;

    Console.WriteLine($"{Math.Sqrt(x*x + y*y):0.0000}");
}
}