using System;//biblioteca .net

class Program { 
  public static void Main () {
    Cinema a = new Cinema();//referencia, instancia
    a.horario = int.Parse(Console.ReadLine());
    a.dia = Console.ReadLine();
    Console.WriteLine($"A inteira foi de {a.total():0.00}");
    Console.WriteLine($"A meia foi de {a.total()/2:0.00}");
      



}
}

class Cinema{
  public int horario;
  public string dia;
  public double total(){
    double entrada=0;
    if(dia=="segunda" || dia=="terca" || dia=="quinta"){
      entrada=16.00;
    }
    if(dia=="sabado" || dia=="domingo" || dia=="sexta"){
      entrada=20.00;
    }
    if(horario >16 && horario <25){
      entrada = entrada*0.5 + entrada;
    }
    if(dia=="quarta"){
      return entrada=8;
    }
    return entrada;


  }
  }
