using System;//biblioteca .net

class Program { 
  public static void Main () {
    string values = Console.ReadLine();
    string[] x =values.Split(' ');

    int n1 = int.Parse(x[0]);
    int n2 = int.Parse(x[1]);
   
   if(n1>n2){
     if(n1%n2==0){
       Console.WriteLine("Sao Multiplos");
     }
     else{
       Console.WriteLine("Nao sao Multiplos");
     }
   }

   if(n2>n1){
     if(n2%n1==0){
       Console.WriteLine("Sao Multiplos");
     }
     else{
       Console.WriteLine("Nao sao Multiplos");
     }
   }
   
   if(n1==n2){
     Console.WriteLine("Sao Multiplos");
   }
}
}