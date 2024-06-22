
//processor core check 
Console.WriteLine("process core number : {0}", Environment.ProcessorCount);

//main thread Id
Console.WriteLine("mian thread ID: {0}", Thread.CurrentThread.ManagedThreadId);


//creating a different thread for each method
Thread thread1 = new Thread(() => Plus(50));
Thread thread2 = new Thread(() => Minus(50));

thread1.Start();
thread2.Start();

static void Plus(int i)
{
    Console.WriteLine("Plus thread ID: {0}", Thread.CurrentThread.ManagedThreadId);
    for (int val = 0; val < i; val++)
    {
        Console.Write("+");
    }
}

static void Minus(int i)
{
    Console.WriteLine("Plus thread ID: {0}", Thread.CurrentThread.ManagedThreadId);
    for (int val = 0; val < i; val++)
    {
        Console.Write("-");
    }
}
