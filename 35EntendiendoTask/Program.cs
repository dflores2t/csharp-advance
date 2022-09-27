using System;
using System.Threading;
using System.Threading.Tasks;

namespace EntendiendoTask
{
  public class Program{
 

    static void Main(string[] args){
      Action<object> action = (object obj) =>
      {
        Console.WriteLine("TASK={0}, obj={1}, Thread={2}", Task.CurrentId, obj, Thread.CurrentThread.ManagedThreadId);
      };

      //CREATE A TASK BUT DO NOT START IT
      Task t1 = new Task(action, "ALPHA");

      //CONSTRUCT A STARTED TASK
      Task t2 = Task.Factory.StartNew(action, "BETA");
      t2.Wait();

      //LAUNCH T1
      t1.Start();
      Console.WriteLine("T1 HAS BEEN LAUNCHED, (MAIN THREAD= {0})",Thread.CurrentThread.ManagedThreadId);

      //WAIT FOR THE TASK TO FINISH
      t1.Wait();

      //CONSTRUCT A STARTED TASK USING TASK.RUN
      string taskData = "DELTA";
      Task t3 = Task.Run(() =>
      {
        Console.WriteLine("Task={0}, obj={1}, Thread={2}", Task.CurrentId, taskData, Thread.CurrentThread.ManagedThreadId);
      });

      //WAIT POR TE TASK TO FINISH.
      t3.Wait();

      //CONSTUCT AN UNSTARTED TASK
      Task t4 = new Task(action, "GAMMA");
      //RUN IT SYNCHRONOUSLY
      t4.RunSynchronously();
      //ALTHOUGH THE TASK WAS RUN SYNCHRONOUSLY, IT IS A GOOD PRACTICE
      // TO WAIT FOR IT IN THE EVENT EXCEPTION WERE THROWN BY THE TASK.
      t4.Wait();

    }


    
  }
}