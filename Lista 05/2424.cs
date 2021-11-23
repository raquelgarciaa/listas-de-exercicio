using System;//biblioteca .net

class Program { 
  public static void Main () {
  string enter = Console.ReadLine();
  string[]  x = enter.Split(' ');

  int a = int.Parse(x[0]);
  int b = int.Parse(x[1]);

  if(a>=0 && a<=432 && b>=0 && b<=468){
      Console.WriteLine("dentro");
  }
  else{
    Console.WriteLine("fora");
  }

}
}