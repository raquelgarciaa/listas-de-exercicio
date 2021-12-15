using System;//biblioteca .net

class Program { 
  public static void Main () {
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    double z = double.Parse(Console.ReadLine());
    Equacao a = new Equacao(x,y,z);//construtor com parametros
    double x1;
    double x2;
    
    if(a.RaizesReais(out x1, out x2)){//out so com referencia
      Console.WriteLine(x1);
      Console.WriteLine(x2);
      }                                   
    if(a.RaizesReais(out x1, out x2)==false){
      Console.WriteLine("Não há raizes reais");
      }
    
}
}

class Equacao{
  private double a;//atributo 1
  private double b;//atributo 2
  private double c;
  //padrao
  public Equacao(){ }
  public void SetABC(double a, double b, double c){
      this.a=a;
      this.b=b;
      this.c=c;
  }
  public void GetABC(out double a, out double b, out double c){
    a=this.a;
    b=this.b;
    c=this.c;
  }
  public bool RaizesReais(out double x1, out double x2){
    if(Delta()<0){
      x1=0;
      x2=0;
      return false;
    }
    x1 = (-b +Math.Sqrt(Delta())) / (2*a);
    x2 = (-b -Math.Sqrt(Delta())) / (2*a);
    return true;
  }
  public double Delta(){
    return (b*b) - (4*a*c);
  }
  //parametros
  public Equacao(double a, double b, double c){
    this.a=a;
    this.b=b;
    this.c=c;
  }
  //saida
  public override string ToString(){
    return ($" A = {a} B = {b} C = {c}");
  }
}

