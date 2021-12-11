using System;//biblioteca .net

class Program { 
  public static void Main () {
    Disciplina a = new Disciplina();//referencia, instancia

    a.nome = Console.ReadLine();
    a.n1 = int.Parse(Console.ReadLine());
    a.n2 = int.Parse(Console.ReadLine());
    a.n3 = int.Parse(Console.ReadLine());
    a.n4 = int.Parse(Console.ReadLine());

    int media1 = a.mediaparcial();
    Console.WriteLine($"Em {a.nome} sua media parcial foi de {media1}");
    if(media1 <=60){
      Console.WriteLine("Escreva sua nota da prova final ");
      a.nota_final= int.Parse(Console.ReadLine());
      int media2 = a.mediafinal();
      Console.WriteLine($"Em {a.nome} sua media final foi de {media2}");
    }


}
}

class Disciplina{
  public string nome;
  public int n1;
  public int n2;
  public int n3;
  public int n4;
  public int nota_final;
  
  public int mediaparcial(){
    return (n1*2) + (n2*2) + (n3*3) + (n4*3) /10;
  }
  public int mediafinal(){
    return (mediaparcial() + nota_final) / 2;
  }
  }



