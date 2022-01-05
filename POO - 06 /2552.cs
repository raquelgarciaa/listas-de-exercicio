using System;//biblioteca .net

class Program {
  public static void Main () {
    bool la=true;
    while(la){
      string a= Console.ReadLine();
      if(string.IsNullOrEmpty(a)){
        break;
      }
      string[] a_v=a.Split(' ');
      int linha = int.Parse(a_v[0]);
      int coluna = int.Parse(a_v[1]);
    //colocando em uma matriz
    int[,] matriz = new int[linha, coluna];//input
    int[,] matriz_2 = new int[linha, coluna];//output
    for(int i =0;i<linha;i++){
      string b = Console.ReadLine();
      string[] b_v = b.Split(' ');
      for(int j=0; j<coluna;j++){
        int ja_la = int.Parse(b_v[j]);
        matriz[i,j] = ja_la;
      }

    }
    
    //positions
    for(int i=0;i<linha;i++){
      for(int j = 0; j<coluna;j++){
        if(matriz[i,j]!=1){
          int embaixo = i+1;
          int cima = i-1;
          int esquerda = j+1;
          int direita = j-1;
          if(embaixo < linha){
            if(matriz[embaixo, j]==1){
              matriz_2[i,j]+=1;
          }
        }
          if(cima >=0){
            if(matriz[cima, j]==1){
              matriz_2[i,j]+=1;
          }
        }
          if(esquerda < coluna){
            if(matriz[i, esquerda]==1){
              matriz_2[i,j]+=1;
          }
        }
          if(direita >= 0){
            if(matriz[i,direita]==1){
              matriz_2[i,j]+=1;
          }
        }
    }
    if(matriz[i,j]==1){
      matriz_2[i,j]=9;
    }
    
  }
}
    //imprimir
    for(int i=0;i<linha;i++){
      for(int j=0;j<coluna;j++){
        Console.Write(matriz_2[i,j]);
      }
      Console.WriteLine();
    }

    }
  }
}
