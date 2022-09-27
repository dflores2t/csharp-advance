namespace UpdateCsharp8;

public class CMensaje{
  //ESTE CASO INVOCA UN MENTODO DENTRO DE UNA CLASE ACTUAL, MUY DIFIL DE UTILIZAR PORQUE NO ES NECESARIO
//TERCER PASO
//PARA INVOCAR UN METODO DE LA CLASE ACTUAL
// ESTO DESDE LUEGO SE PUEDE SIMPLIFIAR

  public void Saluda(){
    Console.WriteLine("HOLA A TODOS");
    this.Despide();
  }

  private void Despide(){
    Console.WriteLine("ADIOS A TODOS");
  }

  //PARA EL CUARTO METODO
  public  void Presentar(CAmigo pAmigo){
    Console.WriteLine("LES PRESENTO A MI AMIGO");
    Console.WriteLine(pAmigo);
  }


  

}