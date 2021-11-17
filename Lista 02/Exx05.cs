using System;//biblioteca .net

class Program { 
  public static void Main () {
    //inserir
    Console.WriteLine("Digite o intervalo de tempo no formato “HH:MM:SS” ");
    string x = Console.ReadLine(); //HH:MM:SS

    //string.Substring(start, tamanho)
    int tamanho = x.Length;
    int h, m, s;
    h = int.Parse(x.Substring(0, 2));
    m = int.Parse(x.Substring(3, 2));
    s = int.Parse(x.Substring(6, 2));

    long dis = (h*3600) + (m*60) + s;
    Console.WriteLine($"A luz percorreu {dis*300000} km nesse intervalo");
  }
}