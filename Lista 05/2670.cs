using System;//biblioteca .net

class Program { 
  public static void Main () {
  /*
  10
  20
  30

  10*2 + 30*2 or 10*4 + 20*2 primeiro andar
  20*2 + 30*4 or 20*2 + 10*2 segundo andar
  30*2 + 10*2 + 30*4 + 20*2  terceiro andar

  equações possiveis
  10*2 + 30*2
  10*4 + 20*2
  20*2 + 30*4
  */
  int n1 = int.Parse(Console.ReadLine());
  int n2 = int.Parse(Console.ReadLine());
  int n3 = int.Parse(Console.ReadLine());

  int[] analise = new int[3];
  analise[0] = (n1*2) + (n3*2);
  analise[1] = (n1*4) + (n2*2);
  analise[2] = (n2*2) + (n3*4);
  int menor = analise[0];

  for(int i = 1; i < 3; i++){
    if(menor>analise[i]){
      menor = analise[i];
    }
  }
  Console.WriteLine(menor);
}
}