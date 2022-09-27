# ENTENDIENDO TASK
The Task class represents a single operation that does not return a value and that usually executes asynchronously. Task objects are one of the central components of the task-based asynchronous pattern first introduced in the .NET Framework 4. Because the work performed by a Task object typically executes asynchronously on a thread pool thread rather than synchronously on the main application thread, you can use the Status property, as well as the IsCanceled, IsCompleted, and IsFaulted properties, to determine the state of a task. Most commonly, a lambda expression is used to specify the work that the task is to perform.

CUANDO TENEMOS UN METODO ASINCRONO EN GENERAL VAMOS A QUERER RETORNAR ALGUNO DE LOS SIGUIENTES TIPOS DE DATOS

## Task instantiation
The following example creates and executes four tasks. Three tasks execute an Action<T> delegate named action, which accepts an argument of type Object. A fourth task executes a lambda expression (an Action delegate) that is defined inline in the call to the task creation method. Each task is instantiated and run in a different way:

Task t1 is instantiated by calling a Task class constructor, but is started by calling its Start() method only after task t2 has started.

Task t2 is instantiated and started in a single method call by calling the TaskFactory.StartNew(Action<Object>, Object) method.

Task t3 is instantiated and started in a single method call by calling the Run(Action) method.

Task t4 is executed synchronously on the main thread by calling the RunSynchronously() method.

Because task t4 executes synchronously, it executes on the main application thread. The remaining tasks execute asynchronously typically on one or more thread pool threads.

## TASK Y TASK<T>
EL TIPO TASK REPRESENTA UNA OPERACION ASINCRONA ES BASICAMENTE UNA PROMESA DE QUE LA OPERACION A REALIZAR NO NECESARIAMENTE VA A CONCLUIR DE MANERA INMEDIANTE PERO EN UN FUTURO SI VA A CONCLUIR.
TAKS ES COMO EL VOID, NO RETORNA NINGUN VALOR
TASK<T> ES PARA METODOS QUE SI RENTORNAN UN VALOR DE TIPO T, STRING INT, DOUBLE, ETC.
NO SE DEBE USAR ASYNC VOID, EXCEPTO PARA EVENT HANDLER

## VALUETASK Y VALUETASK<T>