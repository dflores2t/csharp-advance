namespace InterfacesMetodos;

public class Program
{
  static void Main(string[] args)
  {
    //CREAR ARREGLOS DE INTERFACES
    //LOS ARREGLOS DE INTERFACES SON INTERESANTES PORQUE NOS PERMITE TENER UN ARREGLO DE OBJEOS QUE QUIZAS NO SEAS EXACTAMENTE DE LA MISMA CLASE O NI SIQUIERA ESTEN EN LA MISMA CADENA DE HERENCIA, LO UNICO COMUN ES QUE TENGA LA IMPLEMENTACION DE ESA INTERFAZ.

    IElectronico[] teles = { new CTelevisor("CHARP"), new CTelevisor("ZONY"), new CRadio("RCB"), new CTelevisor("FILIPS") };
    IElectronico aparatoCreado = null;

    for (int n = 0; n < teles.Length; n++)
    {
      Console.WriteLine(teles[n]);
    }
    Console.WriteLine("----------------------");

    //USO DE INTERFACES CON METODOS
    CTelevisor miTV = new CTelevisor("CSHAR TV");
    CRadio miRadio = new CRadio("RCB RADIO");
    Muestra(miRadio);
    Muestra(miTV);
    Console.WriteLine("--------------------------------------");

    //METODO QUE REGRESA OBJETO QUE IMPLEMENTA A LA INTERFAZ
    aparatoCreado = CreaAparato();
    aparatoCreado.Encender(true);
    Console.WriteLine(aparatoCreado);


  }
  //ESTE METODO PUEDE RECIBIR A CUALQUIER OBJETO QUE IMPLEMETE IELETRONICO
  public static void Muestra(IElectronico aparato)
  {
    if (aparato is CTelevisor)
      Console.WriteLine("EL TELEVISOR ES {0}", aparato);
    else
      Console.WriteLine("EL RADIO ES {0}", aparato);
  }

  //ESTE METODO PUEDE REGRESAR CUALQUIER OBJETO QUE IMPLEMENTE A IELECTRONICO
  static IElectronico CreaAparato(){
    IElectronico aparato = null;
    string dato = string.Empty;
    int opcion = 0;

    Console.WriteLine("QUE DESEA CREAR? 1-TELE, 2-RADIO");
    dato = Console.ReadLine();
    opcion = Convert.ToInt32(dato);

    if(opcion == 1){
      Console.WriteLine("DAME LA MARCA DE LA TELE");
      dato = Console.ReadLine();
      aparato = new CTelevisor(dato);
    }
    if(opcion ==2){
      Console.WriteLine("DAME LA MARCA DEL RADIO");
      dato = Console.ReadLine();
      aparato = new CRadio(dato);
    }
    return aparato;
  }
}