//variables
int a = 5;
int b = 8;
int r = 0;

int cantidad = 8;
int sumatoria = 0;
int factorial = 0;

double premodio = 0.0;

//INVOCAMOS EL METODO NORMAL
r = SumaNormal(a, b); //una copia del valor contenido cae en el parametro correspondiente.
System.Console.WriteLine("EL RESULTADO ES {0}",r);

//INTENTAMOS INTERCAMBIAR POR METODO NORMAL
Console.WriteLine("ANTES DEL INTERCAMBIO A={0} B={1}",a,b);
IntercambioNormal(a, b);
Console.WriteLine("DESPUES DEL INTERCAMBIO A={0} B={1}",a,b);
Console.WriteLine("---------------");

//INTERCAMBIO POR REFERENCIA. ref
Console.WriteLine("ANTES DEL INTERCAMBIO A={0} B={1}", a, b);
IntercambioPorReferencia(ref a, ref b);
Console.WriteLine("DESPUES DEL INTERCAMBIO A={0} B={1}", a, b);
Console.WriteLine("---------------");

//MODIFICADOR OUT
//HACEMOS LA INVOCACION PARA CALCULA SUMATORIA Y FACTORIAL
Calculador(cantidad, out sumatoria, out factorial);
Console.WriteLine("SUMATORIO= {0}, FACTORIAL {1}",sumatoria, factorial);

//CALCULA VARIOS PROMEDIOS CON UN NUMERO DIFERENTE DE PARAMETROS
premodio = Promedio(3.5,6.7,8.9);
Console.WriteLine("EL PROMEDIO ES {0}", premodio);
premodio = Promedio(8.0,8.7,10.0,9.0,7.8);
Console.WriteLine("EL PROMEDIO ES {0}", premodio);
premodio = Promedio(7.8,9.0);
Console.WriteLine("EL PROMEDIO ES {0}", premodio);




static int SumaNormal(int x, int y) {
  int z = 0;
  z = x + y;
  return z; //retorna la operacion y lo asigna a r.
}

static void IntercambioNormal(int x , int y){
  int temp = 0;
  temp = x;
  x = y;
  y = temp;
}

static void IntercambioPorReferencia(ref int x, ref int y){    
int temp = 0;
temp = x;
x = y;
y = temp;
}

//METODO QUE POR MEDIO DE OUT REGRESA VALORES
static void Calculador(int n , out int s, out int f){
  s = 0;
  f = 1;
  int m = 0;

  for (m = 1; m <= n; m++){
    s = s + m;
    f = f * m;
  }
}

//PARAMS CANTIDAD VAIRABLE DE PARAMETROS SIN NECESIDADA DE TENER SOBRECARGO, 
//METODO QUE CALCULA EL PROMEDIO DE CUALQUIER CANTIDAD DE PARAMETROS
static double Promedio(params double[] valores){
double suma = 0.0;
double prom = 0.0;
int n = 0;

  for (n = 0; n < valores.Length; n++){ //por la longitud en for sabemos cuantos valores recibios
    suma += valores[n];
  }
  prom = suma / valores.Length;
  return prom;
}