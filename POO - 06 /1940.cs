using System;//biblioteca .net

class Program {
  public static void Main () {
    string a = Console.ReadLine();
    string b = Console.ReadLine();

    string[] a_v =a.Split(' ');
    int partidas = int.Parse(a_v[1]);
    int jogadores = int.Parse(a_v[0]);

    string[] b_v = b.Split(' ');
    //colocando em uma matriz
    int[] matriz = new int[jogadores];
    int index=0;
    for(int i =0;i <partidas;i++){
      for(int j =0; j<jogadores;j++){
        int ja_la = int.Parse(b_v[index]);
        matriz[j]= matriz[j] + ja_la;
        index++; 
      }
    }
    //maior
    int maior = matriz[0];
    int index_maior=0;
    for(int i =0; i<jogadores;i++){
      if(maior<=matriz[i]){
        maior = matriz[i];
        index_maior=i;
      }
    }
    Console.WriteLine(index_maior+1);
  }
}

