using System;//biblioteca .net

class Program { 
  public static void Main () {
    Console.WriteLine("Digite suas notas: ");
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());

    if(Aprovado(n1,n2)){
      Console.WriteLine("Aprovado");
    }
    if(Aprovado(n1,n2)==false){
      Console.WriteLine("Reprovado");
    }

}

  public static bool Aprovado(int nota1, int nota2){
    if(nota1+nota2/2>=60){
      return true;
    }
  return false;
}
}