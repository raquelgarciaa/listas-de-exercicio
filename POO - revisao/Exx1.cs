using System;//biblioteca .net

class Program {
  public static void Main () {
    Console.Write("Informe o número de países: ");
    int number = int.Parse(Console.ReadLine());
    Pais[] lista = new Pais[number];
    //entrada
    for(int i = 0; i< number;i++){
      Console.Write($"Informe o nome do {i+1}° país: ");
      string nome = Console.ReadLine();



      Console.Write($"Informe a população do {i+1}° país: ");
      int pessoas = int.Parse(Console.ReadLine());


      Console.Write($"Informe a área geográfica do {i+1}° país: ");
      int area = int.Parse(Console.ReadLine());
      Pais novo = new Pais(nome, pessoas, area);
      lista[i] = novo;
    }
    //mais populoso e maior area
    int maior_pop = 0;
    int maior_area = 0;
    for(int i =1; i< number;i++){
      if(lista[i].GetPop()>lista[maior_pop].GetPop()){
        maior_pop = i;
      }
      if(lista[i].GetArea()>lista[maior_area].GetArea()){
        maior_area= i;
      }
    }
    //saida
    Console.WriteLine("Resultados");
    Console.WriteLine($"Mais populoso: {lista[maior_pop]} - {lista[maior_pop].GetPop()} habitantes");
    Console.WriteLine($"Maior área: {lista[maior_area]} - {lista[maior_area].GetArea()} km2");
  }
}

class Pais{
  private string nome;
  private int popu;
  private int area;
  public Pais(string nome, int popu, int area){
    this.nome = nome; 
    this.popu = popu;
    this.area = area;
  }

  public int GetPop(){
    return popu;
  }
  public int GetArea(){
    return area;
  }

  public override string ToString(){
    return nome;
  }

}
