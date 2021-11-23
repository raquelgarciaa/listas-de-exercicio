using System;//biblioteca .net

class Program { 
  public static void Main () {
    int enter = int.Parse(Console.ReadLine());
    int primeiro = 0;
    int segundo = 1;

    //Write() same line
    //WriteLine() not the same

    if(enter%2==0){

    
    for(int i = 1; i<=enter/2; i++){
      if(i != enter/2){
        Console.Write($"{primeiro} {segundo} ");
        primeiro = primeiro + segundo;
        segundo = primeiro + segundo;

      }
      if(i == enter/2){
        Console.Write($"{primeiro} {segundo}\n");
        primeiro = primeiro + segundo;
        segundo = primeiro + segundo;
      }
}
}
  if(enter%2!=0){
    for(int i = 0; i<enter; i+=2){
      if(i != enter-1){
        Console.Write($"{primeiro} {segundo} ");
        primeiro = primeiro + segundo;
        segundo = primeiro + segundo;
      }
      if(i == enter-1){
        Console.Write($"{primeiro}\n");
      }
}
  }

}
}