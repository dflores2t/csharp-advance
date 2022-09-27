namespace sortedlistgeneric;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Program {
  static void Main(string[] args){
    SortedSet<CPunto> puntos = new SortedSet<CPunto>();
    puntos.Add(new CPunto(3, 7));
    puntos.Add(new CPunto(8, 11));
    puntos.Add(new CPunto(2, 6));

    //MOSTRAMOS LOS DATOS DE LA COLECCION
    foreach(CPunto p in puntos){
      Console.WriteLine("-->{0}", p);
    }
    Console.WriteLine("------------------");

    //AGREGAMOS MAS -> ESTARAN ORDENADOS DE ACUERDO A SU MAGNITUD
    puntos.Add(new CPunto(1, 15));
    puntos.Add(new CPunto(1, 2));
    //MOSTRAMOS LOS DATOS DE LA COLECCION
    foreach (CPunto p in puntos)
    {
      Console.WriteLine("-->{0}", p);
    }
    Console.WriteLine("------------------");

    Console.WriteLine("----------COLECCION OBSEVRABLE - OBSERVABLECOLLECTION<T>--------------");
    //ESTA ES UNA COLECCION ESPECIAL POQUE LE PODEMOS ADICONAR UNA HANDLER Y PODEMOS TENER CODIGO QUE SE EJECUTE CADA VES QUE SE HAGA UN CAMBIO
    //system.collection.objectmodel
    ObservableCollection<CPunto> puntos1 = new ObservableCollection<CPunto>()
    {
      new CPunto(4,55), new CPunto(17,22)
  };
    //ADICIONAMOS UN HANDLER
    puntos1.CollectionChanged += puntos1_ColloctionChanged; //el nombre del metodo a invocar cuando se haga el cambio a la coleccion.

    puntos1.Add(new CPunto(2, 3));
    CPunto miPunto = new CPunto(5, 5);
    puntos1.Add(miPunto);
    puntos1.Remove(miPunto);
  }
  //ESTE ES EL HANDLER QUE SE INVOCA CUANDO CAMBIA LA COLECCION
  static void puntos1_ColloctionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e){
    //VEMOS EL TIPO DE EVENTO QUE OCURRIO
    Console.WriteLine("EL EVENTO ES {0} ", e.Action);
    //SI LA ACCION ES ADICIONAR
    if(e.Action== System.Collections.Specialized.NotifyCollectionChangedAction.Add){
      Console.WriteLine("ELEMENTOS NUEVOS");
      foreach(CPunto p in e.NewItems){
        Console.WriteLine(p.ToString());
      }
    }
    //SI LA ACCION ES REMOVER
    if(e.Action ==System.Collections.Specialized.NotifyCollectionChangedAction.Remove){
      Console.WriteLine("ELEMENTOS AFECTADOS POR EL CAMBIO");
      foreach(CPunto p in e.OldItems){
        Console.WriteLine(p.ToString());
      }
      Console.WriteLine();
    }
  }

}