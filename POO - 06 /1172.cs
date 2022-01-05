using System;//biblioteca .net

class Program {
  public static void Main () {
    int[] x = new int[10];
    for(int i =0; i<10;i++){
      int y = int.Parse(Console.ReadLine());
      x[i]=y;
    }
    for(int i =0; i<10;i++){
      if(x[i]<=0){
        x[i] =1;
      }
      Console.WriteLine($"X[{i}] = {x[i]}");
    }
  }
}

 