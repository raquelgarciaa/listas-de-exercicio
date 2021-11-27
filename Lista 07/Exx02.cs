using System;//biblioteca .net

class Program { 
  public static void Main () {
    Console.WriteLine("Escreva tres valores: ");
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    double z = double.Parse(Console.ReadLine());
    Console.WriteLine($"O maior valor é : {Maior(x,y,z):0.00}");

}

  public static double Maior(double x, double y, double z){
    double[] numbers = new double[3];
    numbers[0] = x;
    numbers[1] = y;
    numbers[2] = z;

    double maior = x;

    for(int i=1;i<3;i++){
      if(maior<numbers[i]){
        maior = numbers[i];
      }
    }
    return maior;
  }
}