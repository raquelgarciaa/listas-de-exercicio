using System;//biblioteca .net

class Program { 
  public static void Main () {
    int testes = int.Parse(Console.ReadLine());

    for(int i = 0; i<testes; i++){
      string xx = Console.ReadLine();
      string[] jj = xx.Split(' ');

      int x = int.Parse(jj[0]);
      int y = int.Parse(jj[1]);
      if(y!=0){
        double a = Convert.ToDouble(x);
        double b = Convert.ToDouble(y);
        Console.WriteLine($"{a/b:0.0}");
      }
      if(y==0){
        Console.WriteLine("divisao impossivel");
      }

}
}
}