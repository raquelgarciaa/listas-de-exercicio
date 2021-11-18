using System;//biblioteca .net

class Program { 
  public static void Main () {
    string total = Console.ReadLine();
    string[] a= total.Split(' ');
    int want = int.Parse(a[0]);
    int real = int.Parse(a[1]);
    bool la = true;

    int how_much=0;
    while(la){
      want -=real;
      if(want-real==0){
        how_much =0;
        break;
      }
      if(want-real<0){
        how_much=want;
        break;
      }
    }
    Console.WriteLine(how_much);
  }
}
