using System;//biblioteca .net

class Program {
  public static void Main () {
    int size = int.Parse(Console.ReadLine());
    string a = Console.ReadLine();
    string[] array = a.Split(' ');

    int menor =int.Parse(array[0]);
    int index_menor= 0;
    for(int i = 1; i<size;i++){
      if(menor>int.Parse(array[i])){
        menor = int.Parse(array[i]);
        index_menor=i;
      }
    }
    Console.WriteLine($"Menor valor: {menor}");
    Console.WriteLine($"Posicao: {index_menor}");
    }
  }


 