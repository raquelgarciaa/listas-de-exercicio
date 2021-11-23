using System;//biblioteca .net

class Program { 
  public static void Main () {
    int DDD= int.Parse(Console.ReadLine());


  if (DDD == 61){
  Console.WriteLine("Brasilia");
  }
  if (DDD == 71){
  Console.WriteLine("Salvador");
}
  if (DDD == 11){
   Console.WriteLine("Sao Paulo");
}
  if (DDD == 21){
  Console.WriteLine("Rio de Janeiro");
}
  if(DDD == 32){
  Console.WriteLine("Juiz de Fora");
}
  if (DDD == 19){
  Console.WriteLine("Campinas");
}
  if (DDD == 27){
  Console.WriteLine("Vitoria");
}
  if (DDD == 31){
  Console.WriteLine("Belo Horizonte");
}
  if(DDD!=61 && DDD!=71 && DDD!=11 && DDD !=21 && DDD!=32 && DDD!=19 && DDD!=27 && DDD!=31){
    Console.WriteLine("DDD nao cadastrado");
  }

}
}