using System;//biblioteca .net

class Program { 
  public static void Main () {
   Data a = new Data(15,12,2001);//construtor com parametros
   Console.WriteLine(a);
}
}

class Data{
  private int dia;//atributo 1
  private int mes;//atributo 2
  private int ano;
  //padrao
  public Data(){ }
  public void SetData(int dia, int mes, int ano){
    if(dia>0 && dia<32){
      this.dia = dia;
    }
    if(mes>0 && mes<13){
      this.mes=mes;
    }
    if(ano>0){
      this.ano=ano;
    }
  }
  public int GetDia(){
    return dia;
  }
  public int GetMes(){
    return mes;
  }
  public int GetAno(){
    return ano;
  }
  //argumentos
  public Data(int dia, int mes, int ano){
    if(dia>0 && dia<32){
      this.dia = dia;
    }
    if(mes>0 && mes<13){
      this.mes=mes;
    }
    if(ano>0){
      this.ano=ano;
    }
  }
  public Data(string data){
    dia = int.Parse(data.Substring(0,2));
    mes = int.Parse(data.Substring(3,2));
    ano = int.Parse(data.Substring(6,4));
  }
  //saida
  public override string ToString(){
    return ($"{dia:00}/{mes:00}/{ano:0000}");
  }
}
