using System;//biblioteca .net

class Program { 
  public static void Main () {
    Circulo a = new Circulo(); //referencia instancia e obj
    double r1 = double.Parse(Console.ReadLine());
    a.SetRaio(r1);
    Console.WriteLine(a.CalcArea());
    Console.WriteLine(a.CalCircunferencia());
}
}

class Circulo{
  private double raio;
  public void SetRaio(double v){
    if(v>0) raio=v;
  }


  public double GetRaio(){
    return raio;
  }
  public double CalcArea(){
    return raio*raio*3.14;
  }
  public double CalCircunferencia(){
    return raio*2*3.14;
  }
}
