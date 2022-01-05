using System;//biblioteca .net

class Program {
  public static void Main () {
    //matriz e vetor
    int planetas = int.Parse(Console.ReadLine());
    int[,] coordenadas_1= new int[planetas,3];
    for(int i =0;i<planetas;i++){
      string a = Console.ReadLine();
      string[] a_v = a.Split(' ');

      for(int j=0;j<3;j++){
        coordenadas_1[i,j] = int.Parse(a_v[j]);
      }
    }
   //distancia entre cada um
   int[] coordenadas_2 = new int[planetas];
   for(int i =0;i<planetas;i++){
     coordenadas_2[i]=checar(i, coordenadas_1[i, 0], coordenadas_1[i,1], coordenadas_1[i,2],planetas, coordenadas_1);
   }
   //output
   for(int i =0; i<planetas;i++){
     if(coordenadas_2[i]<=20){
       Console.WriteLine("A");
     }
     if(coordenadas_2[i]>20 && coordenadas_2[i]<=50){
       Console.WriteLine("B");
     }
     if(coordenadas_2[i]>50){
       Console.WriteLine("M");
     }
   }
   
    }
public static int checar(int na_linha, int x, int y,int z, int max,int[,] vetor){
  int[] a = new int[max];
  int j=0;
  for(int i =0;i<max;i++){
    if(i!=na_linha){
      double part_1 = (vetor[i,0]-x) * (vetor[i,0] -x);
      double part_2 = (vetor[i,1]-y)*(vetor[i,1]-y);
      double part_3 =  (vetor[i,2]-z)*(vetor[i,2]-z);
      double aa = part_1 + part_2 + part_3;
      a[j] = int.Parse(Math.Sqrt(aa));
      j++;
  }
}
Array.Sort(a);
int retorno = a[0];
return retorno;
}
}
