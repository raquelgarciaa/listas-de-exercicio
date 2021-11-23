using System;//biblioteca .net

class Program { 
  public static void Main () {
    bool la =true;
    while(la){
    int n1= int.Parse(Console.ReadLine());
    if(n1!=2002){
      Console.WriteLine("Senha Invalida");
    }
    if(n1==2002){
      Console.WriteLine("Acesso Permitido");
      la=false;
      break;
    }
    
    }
}
}