using System;//biblioteca .net

class Program {
  public static void Main () {
    int[] n = new int[10];
    int first= int.Parse(Console.ReadLine());
    n[0] = first;
    for(int i =1; i<10;i++){
      n[i]=n[i-1]*2;
    }
    for(int i =0; i<10;i++){
      Console.WriteLine($"N[{i}] = {n[i]}");
    }
  }
}

 