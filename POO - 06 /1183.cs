using System;//biblioteca .net

class Program {
  public static void Main () {
    string sum_media = Console.ReadLine();
    double[,] array = new double[12,12];
    for(int i =0; i<12;i++){
      for(int j =0; j<12;j++){
        double number = double.Parse(Console.ReadLine());
        array[i,j] = number;
        }
      }
    int start=0;
    double sum=0;
    for(int i =0; i<12;i++){
      start++;
      for(int j=start; j<12;j++){// 1 2 3 4 5 6 7...
        sum+=array[i,j];
        Console.WriteLine($"first {i}, {j}");        
        //if(j==11){
         // start++;
       // }
      }
       //2 3 4 5 6 7...
    }
  if(sum_media=="S"){
    Console.WriteLine($"{sum:0.0}");
  }
  if(sum_media=="M"){
    Console.WriteLine($"{sum/66:0.0}");
  }
  }
  }


 