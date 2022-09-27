namespace UpdateCsharp8
{

  public class CAutomovil{

    private string modelo = "NUNGUN ASIGNADO";

    //PRIMER USO
    //USAMOS THIS PARA QUITAR LA AMBIGUEDAD ENTRE EL NOMBRE DEL PAMETRO Y EL ATRIBUTO

    public CAutomovil(string modelo)
    {
      //AQUI APARECE UNA AMBIGUEDAD PARA QUIEN LEA EL CODIGO
      // PARA LA COMPUTADORA ES MODELO EL PARAMETRO
      // modelo = "VOCHITO"; //ESTO QUEDA REFERENCIADO AL PARAMETRO Y NO AL ATRIBUTO
      // this.modelo = "RENAULT"; //LA INFO SE COLOCA EN EL ATRIBUTO

      //AHORA INDICAMOS QUE USAMOS EL ATRIBUTO
      // THIS ES UNA AUTOREFERENCIA AL ABJETO QUE ESTA EJECUTANDO EL CODIGO 
      //this.modelo = "RENAULT

      this.modelo = modelo; //this tomara el valro del parametro modelo

      //QUITAR LA AMBIGUEDAD ENTRE VARIABLE Y PRAMETRO.



    }

    public override string ToString()
    {
      return String.Format("TU AUTO ES {0}", modelo);
    }
  }
}