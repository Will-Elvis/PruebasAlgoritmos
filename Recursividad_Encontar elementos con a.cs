using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    // de manera recursiva recorrer  el arraylist y imprimir los elementos que empiecen con la letra A

    ArrayList lista = new ArrayList();
    lista.Add("Gordon");
    lista.Add("Pedro");
    lista.Add("Maria");
    lista.Add("Juan");
    lista.Add("Angel");
    EncontrarPalabra(lista,0);

  }
  public static void EncontrarPalabra(ArrayList lista, int k){
    if(k == lista.Count){
      return;
    }
    if(lista[k].ToString()[0] == 'A'){
      Console.WriteLine(lista[k]);
    }
    EncontrarPalabra(lista, k+1);
  }
}
