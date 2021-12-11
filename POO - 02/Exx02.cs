using System;//biblioteca .net

class Program { 
  public static void Main () {
    Disciplina a = new Disciplina();//referencia, instancia

    a.SetNome(Console.ReadLine());
    a.SetNota1(int.Parse(Console.ReadLine()));
    a.SetNota2(int.Parse(Console.ReadLine()));
    a.SetNota3(int.Parse(Console.ReadLine()));
    a.SetNota4(int.Parse(Console.ReadLine()));

    Console.WriteLine($"Sua média parcial foi de {a.CalcMediaParcial()}");
    if(a.CalcMediaParcial()<60){
      Console.WriteLine("Não foi aprovado por média. Escreva sua nota na prova final ");
      a.SetNotaFinal(int.Parse(Console.ReadLine()));
      Console.WriteLine($"Sua média final foi de {a.CalcMediaFinal()}");
    }
}
}

class Disciplina{
  private string nome;
  private int nota1;
  private int nota2;
  private int nota3;
  private int nota4;
  private int notaFinal;
  
  public void SetNome(string s){
    nome = s;
  }
  public void SetNota1(int n){
  if(n>=0 || n <=100){
    nota1=n;
  }
  }
  public void SetNota2(int n){
  if(n>=0 || n<=100){
    nota2=n;
  }
  }
  public void SetNota3(int n){
  if(n>=0 || n<=100){
    nota3=n;
  }
  }
  public void SetNota4(int n){
  if(n>=0 || n<=100){
    nota4=n;
  }
  }
  public void SetNotaFinal(int n){
  if(n>=0 || n<=100){
    notaFinal=n;
  }
  }
  
  public string GetNome(){
    return nome;
  }
  public int GetNota1(){
    return nota1;
  }
  public int GetNota2(){
    return nota2;
  }
  public int GetNota3(){
    return nota3;
  }
  public int GetNota4(){
    return nota4;
  }
  public int GetNotaFinal(){
    return notaFinal;
  }


  public int CalcMediaParcial(){
    return (nota1*2 + nota2*2 + nota3*3 + nota4*3) / 10;
  }
  public int CalcMediaFinal(){
    return (CalcMediaParcial() + notaFinal) /2;
  }
  }