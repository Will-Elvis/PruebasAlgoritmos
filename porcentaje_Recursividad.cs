using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    ArrayList listaAlturas = new ArrayList();
    // ArrayList alumnos = new ArrayList();
    // Alumno alumno1 = new Alumno(1.75);
    // Alumno alumno2 = new Alumno(1.62);
    // Alumno alumno3 = new Alumno(1.80);
    // Alumno alumno4 = new Alumno(1.67);
    // Alumno alumno5 = new Alumno(1.61);
    // Alumno alumno6 = new Alumno(1.71);
    // Alumno alumno7 = new Alumno(1.85);
    // alumnos.Add(alumno1);
    // alumnos.Add(alumno2);
    // alumnos.Add(alumno3);
    // alumnos.Add(alumno4);
    // alumnos.Add(alumno5);
    // alumnos.Add(alumno6);
    // alumnos.Add(alumno7);
    
    listaAlturas.Add(1.53);
    listaAlturas.Add(1.75);
    listaAlturas.Add(1.62);
    listaAlturas.Add(1.80);
    listaAlturas.Add(1.67);
    listaAlturas.Add(1.61);
    listaAlturas.Add(1.71);
    listaAlturas.Add(1.85);
    CalcularAlturaPromedio(listaAlturas, 0,0);
    
  }
  // =====================
  
  public static void CalcularAlturaPromedio(ArrayList listaAlturas, int k, int contador){
    
    if (k == listaAlturas.Count){
      double porcentaje = ( (double)contador/k) * 100 ;
      Console.WriteLine("El porcentaje de alumnos que superan 1,75m es: " + porcentaje + " %");
      return;
    }
    if ((double)listaAlturas[k] >= 1.75){
      contador++;
    }
    CalcularAlturaPromedio(listaAlturas, k + 1, contador);
  }
}




// Clase Alumno ===============
// public class Alumno {
//   private double altura;
//   public Alumno(double altura){
//     this.altura = altura;
//   }
//   public double Altura{
//     get{return altura;}
//     set{altura = value;}
//   }
// }
