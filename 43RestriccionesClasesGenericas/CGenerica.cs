namespace RestriccionesClasesGenericas
{
  //ESTA ES LA CLASE GENERICA A LA CUAL LE PONDREMOS LAS RESTRICCIONES
  //BASE-CLASS, T DEBE SER UNA SUBCLASE DE UNA CLASE EN PARTICULAR
  //WHERE T: CLASE-BASE
  //WHERE T: CLASE
  //WHERE T: INTERFAZ
  //WHERE T: STRUCT
  //WHERE T; NEW()
  public class CGenerica<T> where T: IInterfaz //t unicamente puede ser ca o en la cadena de herencia ca
  {
    T objeto;

    public CGenerica(T pObjeto)
    {
      objeto = pObjeto;
    }

    public void Repetir()
    {
      int n = 0;
      for (n = 0; n < 5; n++)
        Console.WriteLine(objeto);
    }
  }
}