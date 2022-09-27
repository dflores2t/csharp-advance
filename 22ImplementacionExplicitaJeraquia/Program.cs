namespace ImplementacionExplicita;

public class Program{
  static void Main(string[] args){

    //FORMA DE IMPLEMENTAR DOS INTERFACEN CON EL MISMO NOMBRE DE METODO
    Ccuadrado cuadrado = new Ccuadrado(5);
    // cuadrado.cual///el metodo no aparece, porque tengo que ser explicito para indicar con cual calcular trabajar

    ((IPerimetro)cuadrado).Calcular();
    ((IArea)cuadrado).Calcular();


    ////JARARQUIA -> interfaces IMostrar e ICalcular clase Suma
    Console.WriteLine("---------------------------------");
    CSuma miSuma = new CSuma();

    //metodo debido a icalcular
    miSuma.Calculo(5, 3);
    //metodo debido a la jerarquia en icalural
    miSuma.MostrarDatos();



  }
}