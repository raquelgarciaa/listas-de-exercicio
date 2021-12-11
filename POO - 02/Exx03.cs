using System;//biblioteca .net

class Program { 
  public static void Main () {
    Viagem a = new Viagem();//referencia, instancia
    a.SetDistancia(double.Parse(Console.ReadLine()));
    a.SetTempo(double.Parse(Console.ReadLine()));
    Console.WriteLine($"A velocidade obtida foi de {a.VelocidadeMedia():0.0}");



}
}

class Viagem{
  private double distancia;
  private double tempo;
  public void SetDistancia(double d){
    if(d>=0){
      distancia=d;
    }
  }
  public void SetTempo(double t){
    if(t>=0){
      tempo=t;
    }
  }

  public double GetDistancia(){
    return distancia;
  }
  public double GetTempo(){
    return tempo;
  }
  
  public double VelocidadeMedia(){
    return distancia/tempo;
  }
  }

