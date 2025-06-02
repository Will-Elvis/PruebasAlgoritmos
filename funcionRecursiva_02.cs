using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    ArrayList lista = new ArrayList();
    lista.Add(10000);
    lista.Add(2394);
    lista.Add(8000);
    ImprimirButacas(lista,0);
  }
  //funcion recursuva que imprime las butacas
  public static void ImprimirButacas(ArrayList lista, int k){
    if(k == lista.Count){
      return;
    }
    if((int)lista[k] > 2500){
      Console.WriteLine(lista[k]);
    }
    ImprimirButacas(lista,k+1);
  }
}

