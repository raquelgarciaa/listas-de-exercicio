using System;//biblioteca .net

class Program { 
  public static void Main () {
    Console.WriteLine("Digite seu nome completo: ");
    string name = Console.ReadLine();
    Console.WriteLine($"As iniciais do seu nome são {Iniciais(name)}");

}

  public static string Iniciais(string nome){
    string todas="";
    string[] total = nome.Split(' ');
    for(int i =0; i<total.Length; i++){//Gil, Araujo
      todas+=total[i].Substring(0,1);//G
  }
  return todas;
}
}