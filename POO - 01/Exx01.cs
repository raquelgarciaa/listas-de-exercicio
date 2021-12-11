using System;//biblioteca .net

class Program { 
  public static void Main () {
    Circulo a = new Circulo(); //referencia instancia e obj
    double r1 = double.Parse(Console.ReadLine());
    a.raio = r1;
    Console.WriteLine(a.area());
    Console.WriteLine(a.circun());
}
}

class Circulo{
  public double raio;
  public double area(){
    return raio*raio*3.14;
  }
  public double circun(){
    return raio*2*3.14;
  }
}
