using System;//biblioteca .net

class Program { 
  public static void Main () {
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    Retangulo a = new Retangulo(x,y);//construtor com parametros
    
    Console.WriteLine(a.CalcArea());
    Console.WriteLine(a.CalcDiagonal());
}
}

class Retangulo{
  private double b;
  private double h;
  //padrao
  public Retangulo(){ }
  public void SetBase(double b){
    if(b>0){
      this.b=b;
    }
  }
  public void SetAltura(double h){
    if(h>0){
      this.h=h;
    }
  }
  public double GetBase(){
    return b;
  }
  public double GetAltura(){
    return h;
  }
  public double CalcArea(){
    return b*h;
  }
  public double CalcDiagonal(){
    return Math.Sqrt(b*b + h*h);
  }
  //parametros
  public Retangulo(double b, double h){
    if(b>0 && h>0){
      this.b=b;
      this.h=h;
    }
  }
  //saida
  public override string ToString(){
    return $"Base = {b} e Altura = {h}";
  }
  }

