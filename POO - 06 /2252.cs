using System;//biblioteca .net

class Program {
  public static void Main () {
    bool la = true;
    int vezes=1;
    while(la){
      string input = Console.ReadLine();
      int result=0;
      if(int.TryParse(input, out result)==false){
        break;
      }
      //sequencia
      string a = Console.ReadLine();
      string[] b = a.Split(' ');
      double[] oil = new double[10];
      for(int i =0;i<10;i++){
        oil[i] = double.Parse(b[i]);
        }
      //sequencia do maior para menor
      double[] position = new double[10];
      oil.CopyTo(position,0);
      Array.Sort(position);
      Array.Reverse(position);
      //localizar e imprimir
      string total="";
      for(int i=0; i<result;i++){
        string part= Array.IndexOf(oil,position[i]).ToString();
        oil[Array.IndexOf(oil,position[i])]=-1;
        total+=part;
      }
      Console.WriteLine($"Caso {vezes++}: {total}");




    }
  }
}

