using System;//biblioteca .net

class Program { 
  public static void Main () {
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    Frete a = new Frete(x,y);//construtor com parametros

    Console.WriteLine(a.CalcFrete());
}
}

class Frete{
  private double d;//atributo 1
  private double p;//atributo 2
  //padrao
  public Frete(){ }
  public void SetDistancia(double d){
    if(d>0){
      this.d=d;
    }
  }
  public void SetPeso(double p){
    if(p>0){
      this.p=p;
    }
  }
  public double GetDistancia(){
    return d;
  }
  public double GetPeso(){
    return p;
  }
  public double CalcFrete(){
    return d*p;
  }
  //parametro
  public Frete(double d, double p){//construtor com argumentos
    if(d>0 && p>0){
      this.d=d;
      this.p=p;
    }
  }
  //saida
  public override string ToString(){
    return $"Distancia = {d} e Peso = {p}";
  }
  }
