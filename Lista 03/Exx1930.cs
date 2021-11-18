using System;//biblioteca .net

class Program { 
  public static void Main () {
    string s = Console.ReadLine();
    string[] a = s.Split(' ');

    int n1 = int.Parse(a[0]);
    int n2 = int.Parse(a[1]);
    int n3 = int.Parse(a[2]);
    int n4 = int.Parse(a[3]);

    Console.WriteLine((n1-1) + (n2-1) + (n3-1) + n4);

}
}