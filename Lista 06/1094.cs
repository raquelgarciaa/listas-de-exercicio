using System;//biblioteca .net

class Program { 
  public static void Main () {
    int testes = int.Parse(Console.ReadLine());
    int total=0;

    int c=0;
    int r=0;
    int s=0;
    for(int i = 0; i<testes; i++){
      string x = Console.ReadLine();
      string[] j = x.Split(' ');
      int a = int.Parse(j[0]);
      string b = j[1];
      total+=a;

      if(b=="C"){
        c+=a;
      }
      if(b=="R"){
        r+=a;
      }
      if(b=="S"){
        s+=a;
      }
    }
    double cc = Convert.ToDouble(c);
    double rr = Convert.ToDouble(r);
    double ss = Convert.ToDouble(s);

    double p_c = (cc*100)/total;
    double p_r = (rr*100)/total;
    double p_s = (ss*100)/total;
    Console.WriteLine($"Total: {total} cobaias");
    Console.WriteLine($"Total de coelhos: {c}");
    Console.WriteLine($"Total de ratos: {r}");
    Console.WriteLine($"Total de sapos: {s}");
    Console.WriteLine($"Percentual de coelhos: {p_c:0.00} %");
    Console.WriteLine($"Percentual de ratos: {p_r:0.00} %");
    Console.WriteLine($"Percentual de sapos: {p_s:0.00} %");
}
}