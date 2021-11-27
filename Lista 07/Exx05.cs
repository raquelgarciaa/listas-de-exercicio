using System;//biblioteca .net

class Program { 
  public static void Main () {
    Console.WriteLine("Digite seu nome: ");
    string x = Console.ReadLine();
    Console.WriteLine(FormatarNome(x));


}

  public static string FormatarNome(string nome){
    string everything="";
    string[] total = nome.Split(' ');
    for(int i =0; i<total.Length; i++){//gIL
      //primeira letra
      string first = total[i].Substring(0,1);//g
      string rest = total[i].Substring(1,total[i].Length-1);//IL
      everything= everything + first.ToUpper()+rest.ToLower()+" ";
}
  return everything;
}
}