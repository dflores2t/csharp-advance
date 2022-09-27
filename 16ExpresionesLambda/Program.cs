namespace expresionesLambda;

public class Program{
  static void Main(string[] args){
    //EXPRESIONES LAMBDA

    //HACEMOS LO MISMO QUE EN EL EJEMPLO ANTERIOR, PERO CON EXPRIESION LAMBDA
    //SOLO SE PUEDE USAR DONDE SE HAGA USO DE UN METODO ANONIMO O UN DELEGADO FUERTEMENTE TIPADO.

    //LISTA DE PARAMETROS => INSTRUCCIONES A REALIZAR
    // EL TIPO DE LO PARAMETROS PUED SER IMPILICOT O EXPLICITO (INT I)
    List<int> numeros = new List<int>();
    numeros.AddRange(new int[] { 1,2,3,4,5,6,7,8,9,10});

    //HACEMOS USO DE LA EXPRESION LAMDA
    List<int> numPares = numeros.FindAll(i=> (i % 2) == 0);

    //MOSTRAMOS LOS NUMEROS 
    foreach(int n in numPares)
      Console.WriteLine(n);


    //OTRO EJEMPLO
    //LAMDA DE FORMA MAS COMPLEJA
Console.WriteLine("------------------------II PARTE------------------------");
    //USO DE LA EXPRESION LAMDA
    List<int> numPares2 = numeros.FindAll(i =>
    {
      if (i % 2 == 0)
      {
        Console.WriteLine("un par");
        return true;
      }else{
        Console.WriteLine("un impar");
        return false;
      }
    });

    //MOSTRAMOS LOS NUMEROS
    foreach(int n in numPares2){
      Console.WriteLine(n);
    }
  }
}