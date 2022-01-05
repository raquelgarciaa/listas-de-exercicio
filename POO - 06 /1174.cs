using System;//biblioteca .net

class Program {
  public static void Main () {
    double[] a = new double[100];
    for(int i=0;i<100;i++){
      double aa = double.Parse(Console.ReadLine());
      a[i] =aa;
    }
    for(int i=0;i<100;i++){
      if(a[i]<=10){
        Console.WriteLine($"A[{i}] = {a[i]:0.0}");
      }
    }
  
    /*
    int aa=0;
    double bb=0;
    if(int.TryParse(a, out aa)==true || double.TryParse(a, out bb)==true){
      Console.WriteLine("aaa");
      */
    }
  }

