using System;//biblioteca .net

class Program { 
  public static void Main () {
    Viagem a = new Viagem();//referencia, instancia
    a.distancia = double.Parse(Console.ReadLine());
    a.tempo = double.Parse(Console.ReadLine());
    double vel_media = a.velocidade_media();
    Console.WriteLine($"A velocidade obtida foi de {vel_media:0.0}");



}
}

class Viagem{
  public double distancia;
  public double tempo;
  public double velocidade_media(){
    return distancia/tempo;
  }
  }
