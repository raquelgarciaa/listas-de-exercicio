using System;//biblioteca .net

class Program { 
  public static void Main () {
    Cinema a = new Cinema();//referencia, instancia
    a.SetHorario(int.Parse(Console.ReadLine()));
    a.SetDia(Console.ReadLine());
    Console.WriteLine($"A inteira foi de {a.Total():0.00}");
    Console.WriteLine($"A meia foi de {a.Total()/2:0.00}");
      



}
}

class Cinema{
  private int horario;
  private string dia;
  public void SetHorario(int h){
    if(h>0 && h<=24){
      horario=h;
    }
  }
  public void SetDia(string d){
    dia=d;
  }

  public int GetHorario(){
    return horario;
  }
  public string GetDia(){
    return dia;
  }

  public double Total(){
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

