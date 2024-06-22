﻿//thread wait 
Console.WriteLine("Before task starting.");

var task = Task.Run(() =>
{

    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("Iteration number {0}", i);

    }
});
task.Wait();

Console.WriteLine("The task has finished.");

//continuewith to chain the operationsa nd await 1 by 1 

static int LengthCalculation(string String)
{
    Console.WriteLine("Length of the string is : {0}", String);

    return String.Length;

}

Task taskConstinuation = Task.Run(() => LengthCalculation("First Task starting")).ContinueWith(t => Console.WriteLine(t.Result))
    .ContinueWith(afteCompletion =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("second task startig");
    });

taskConstinuation.Start();
