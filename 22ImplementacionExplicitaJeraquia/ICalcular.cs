namespace ImplementacionExplicita;
//CREAMOS LA JERARQUIA DE LA INTERFACES
// AHORA ICALCULAR APARTE DE CALCULA TIENE LOS MENODO DE IMOSTRAR
public interface ICalcular:IMostrar{ //jarquia de interfaces, cualquiero objeto que implemetno icalcula esta forzado a implementar imostrar
  int Calculo(int a, int b);
}