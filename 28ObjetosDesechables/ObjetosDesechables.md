# OBJETOS DESECHABLES
SI DESEAMOS QUE LOS RECURSOS NO ADMINISTRADOS SEAN LIBERADOS TAN PRONTO COMO SEA POSIBLE EN LUGAR DE QUE LO HAGA EL RECOLECTOR DE BASURA
PODEMOS IMPLEMENTAR LA INTERFAZ IDISPOSABLE.
EN ESTE CASO SE TOMA QUE CUANDO EL USUARIO DEJA DE USAR EL OBJETO, EL USUARIO INVOCA DISPOSE(),  SE LIBERA LO NO ADMINISTRADO, PERO EL OBJETO SIGUE EXISTIENDO.

* IDISPOSABLE
* DISPOSE()
* USING

# OBJETO DESECHABLE Y FINALIZABLE
CREAR UN OBJETO QUE ES DESECHABLE Y FINALIZABLE
SUPRIMR LA INVOCACION DEL DESTRUCTOR