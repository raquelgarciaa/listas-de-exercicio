using System;//biblioteca .net

class Program {
  public static void Main (){
    //entrada
    Carrinho compras= new Carrinho();
    bool la = true;
    while(la){
      string descricao = Console.ReadLine();
      int qtd = int.Parse(Console.ReadLine());
      double preco = double.Parse(Console.ReadLine());
      if(qtd==0 && preco==0 && descricao=="0"){//0 0 0
        break;
      }
      Produto novo = new Produto(descricao, qtd, preco);
      compras.Inserir(novo);

    }
    
    //saida
    foreach(Produto i in compras.Listar()){
      Console.WriteLine(i);//descrição - preço - quantidade
    }
    Console.WriteLine($"O total das compras foi de {compras.Somar()}");
  }
}

class Carrinho{
  private Produto[] produs = new Produto[50];//1,2,3,4........50
  int index=0;//posicao

  public void Inserir(Produto p){
    if(index<50){
      produs[index] = p;
      index++;
      //posição 0 - descrição + preço + qtd - index 1
      //psoição 1 - descrição + preço + qtd - index 2
    }
  }

  public Produto[] Listar(){
    Produto[] aux_produs = new Produto[index];//{0,0}
    Array.Copy(produs, aux_produs, index);//{produto, produto,0,0,0,0...} - > {produto, produto}
    return aux_produs;//{produto, produto}
  }

  public double Somar(){
    double final=0;
    for(int i =0; i<index; i++){
      final += produs[i].GetPreco() * produs[i].GetQtd();
    }
    return final;
  }

}

class Produto{
  private string descricao;
  private int qtd;
  private double preco;

  public Produto(string descricao, int qtd, double preco){
    this.descricao = descricao;
    this.qtd = qtd;
    this.preco = preco;
  }

  public int GetQtd(){
    return qtd;
  }
  public double GetPreco(){
    return preco;
  }

  public override string ToString(){
    return$"descrição = {descricao} - preço = {preco} - quantidade = {qtd}";
  }

}