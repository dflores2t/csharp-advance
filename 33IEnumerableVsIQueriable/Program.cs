using _33IEnumerableVsIQueriable;

namespace BloqueIqueryable
{
  class Program{
    static void Main(string[] args){
      //EVALUAR DIFERENCIA ENTRE INTERFACE IENUMERABLE E IQUERIABLE, IENUMERABLE ALGO QUE SE PUEDE ENEMURAR Y SE PUEDE RECORER COM UN FOREACH IQUERIABLE ES PARA HACER CONSULTA.

      //IENUMRABLE CUANDO SE TRABAJA CON LINQ SOBRE UN ELEMENTO QUE IMLPMENTA IENUMERABLE SOBRE UN ELEMENTO QUE ES LINQ TO OBJECT TRABAJARA SOBRE MEMORIA
      //IQUERIABLE TRABAJARA SOBRE LINQ TO SQL, ES DICER TRABAJA CON CONSULTA.

      //AGREGAR ENTITYFRAMEWORK

      using(var db = new pubContext()){
        //VERSION 1: LINQ ESTE TIPO DE DATO EN LA CONSULTA ES DECIR AL LADO DERECHO DEL IGUAL ES UN IQUERIABLE ES DECIR ES UNA CONSULTA COMO TAL, PERO AL MOMENTO DE TRANSFORMARLA A IENUMERABLE PASA A SER MEMORIA.
        IEnumerable<Brand> list = from b in db.Brands
                                  select b;
        //ES DECIR VA A LA BD Y YA TRAJO LOS ELEMENTOS.

        //MOSTRAMOS LOS DATOS
        foreach(var ls in list){
          Console.WriteLine("id:{0} - marca:{1}",ls.BrandId,ls.Name);
        }

        //DIFERENCIA
        Console.WriteLine("----------DIFERENCIA----------");
        list=list.Where(b => b.BrandId ==211); //AL HACER ESTO ESTAMOS TRABJANDO CON LOS DATOS EN MEMORIA
        //SI HACEMOS IENUMERABLE Y POSTERIORMENTE HACEMOS WHERE, SE ESTARA TRABAJANDO CON LA MEMORIA, SI HAY MILLONES DE DATOS ETC
        //FORMULARIOS DE BUSQUEDAS SERIA MUY LENTO, TRAER LOS DATOS Y LUEGO BUSCAR EN MEMORIA EN LUGAR DE LA BD.

        //MOSTRAMOS LOS DATOS
        foreach (var ls in list)
        {
          Console.WriteLine("id:{0} - marca:{1}", ls.BrandId, ls.Name);
        }

        //VERSION 2: CAMBIAR A IQUERIABLE
        Console.WriteLine("--------VERSION 2: CAMBIAR A IQUERIABLE");
        IQueryable<Brand> lst = from b in db.Brands select b; //ESTO ES CONSULTA
        lst = lst.Where(b => b.Name.Contains("VICTORIA CLASICA")); //ESTO SERIA UNA NUEVA CONSULTA A SQL, SE ESTARIA CONCATENANDO CONSULTAS Y NI SIQUIERA HA IDO A L BD. ELTOSTRING LO CONVIERTE EN MEMORIA.

        //MOSTRAMOS LOS DATOS
        foreach (var ls in lst) //AQUI IRIA A LA BD
        {
          Console.WriteLine("id:{0} - marca:{1}", ls.BrandId, ls.Name);
        }

      }


    }
  }
}