using System;//biblioteca .net

class Program { 
  public static void Main () {

  string vertebras = Console.ReadLine(); 
  string estilo = Console.ReadLine();
  string comida = Console.ReadLine();
  if (vertebras == "vertebrado"){
    if (estilo == "ave"){
      if (comida == "carnivoro"){
        Console.WriteLine("aguia");
      }
      if (comida == "onivoro"){
        Console.WriteLine("pomba");
      }
    }

    if (estilo == "mamifero"){
      if (comida == "onivoro"){
        Console.WriteLine("homem");
      }
      if (comida == "herbivoro"){
        Console.WriteLine("vaca");
      }
    }
  }

  if (vertebras == "invertebrado"){
    if (estilo == "inseto"){
      if (comida == "hematofago"){
        Console.WriteLine("pulga");
      }
      if (comida == "herbivoro"){
       Console.WriteLine("lagarta");
      }
    }
    
    if (estilo == "anelideo"){
      if (comida == "hematofago"){
        Console.WriteLine("sanguessuga");
      }
      if (comida == "onivoro"){
        Console.WriteLine("minhoca");
      }
    }
  }
}
}