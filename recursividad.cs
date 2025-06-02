using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    //creamos una lista de butacas
    ArrayList lista = new ArrayList();
    Butaca b1 = new Butaca(1,10000);
    Butaca b2 = new Butaca(2,2394);
    Butaca b3 = new Butaca(3,8000);
    Butaca b4 = new Butaca(4,3000);
    Butaca b5 = new Butaca(5,5000);
    lista.Add(b1);
    lista.Add(b2);
    lista.Add(b3);
    lista.Add(b4);
    lista.Add(b5);
    ImprimirButacas(lista,0);
  }
  //funcion recursuva que imprime las butacas
  public static void ImprimirButacas(ArrayList lista, int k){
    if(k == lista.Count){
      return;
    }
    
    if(((Butaca)lista[k]).Precio > 2500){
      Console.WriteLine("El numero de Butaca es : " + ((Butaca)lista[k]).Numero);
      Console.WriteLine("El precio de la butaca es : " + ((Butaca)lista[k]).Precio);
      Console.WriteLine("-----------------------------------------");
    }
    
    ImprimirButacas(lista,k+1);
  }
}

public class Butaca{
  private int numero;
  private int precio;
  public Butaca(int n,int p){
    numero = n;
    precio = p;
  }
  public int Numero{
    get{return numero;}
    set{numero = value;}
  }
  public int Precio{
    get{return precio;}
    set{precio = value;}
  }
}
