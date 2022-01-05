using System;//biblioteca .net

class Program { 
  public static void Main () {
    bool la=true;
    while(la){

      string input = Console.ReadLine();
      int result;
      if(int.TryParse(input, out result)==false){
      break;
    }

      int[,] pares = new int[result, 2];//{{38, 38}, {40, 40}}
      int total=0;
    // todos os sapatos
      for(int i=0; i<result; i++){

        string linha = Console.ReadLine();
        string[] dividir_linha = linha.Split(' ');// 41 E
        int number = int.Parse(dividir_linha[0]);//41
        string pe = dividir_linha[1];//E
        if(pe=="E"){
          int search = encontrar(pares, i, 0, number);
          if(search==-1){
            pares[i,0]=number;//41, 0
          }
          if(search!=-1){//41, 41
          pares[search,0] =number;
            total++;//um par
          }
        }
        if(pe=="D"){
          int search = encontrar(pares, i, 1, number);
          if(search==-1){
            pares[i,1]=number;//41, 0
          }
          if(search!=-1){//41, 41
            pares[search,1]=number;
            total++;//um par
          }
        }
      }
    Console.WriteLine(total);

    }
}
public static int encontrar(int[,] list, int tamanho, int e_ou_d, int number){
  for(int i = 0; i<tamanho; i++){
    if(e_ou_d==1){//direito
      if(list[i,0]==number && list[i,1]==0){//tem /  nao tem
        return i;
      }
    }
    if(e_ou_d==0){//esquerd
      if(list[i, 0]==0 && list[i, 1]==number){//nao tem / tem
        return i;
      }
    }
  }
  return -1;
}

}