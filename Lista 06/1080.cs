using System;//biblioteca .net

class Program { 
  public static void Main () {
    int n1= int.Parse(Console.ReadLine());
    int maior=n1;
    int position=0;
    for(int i =1; i<100; i++){
      int n2= int.Parse(Console.ReadLine());
      if(n2>maior){
        maior=n2;
        position=i;
      }
    }
    Console.WriteLine(maior);
    Console.WriteLine(position);
}
}