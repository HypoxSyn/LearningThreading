/*
string test = DateTime.Now.ToString("HH:mm:ss tt");
Console.WriteLine(test);
Thread.Sleep(1000);
Console.WriteLine(test);
Thread.Sleep(1000);
Console.WriteLine(test);
Thread.Sleep(1000);

new Thread(() =>
{
   string test = DateTime.Now.ToString("HH:mm:ss tt");

   int i = Add(5, 5);
   Console.WriteLine(test);
   global::System.Console.WriteLine(i);
   Thread.Sleep(1000);

   new Thread(() =>
   {
       string test = DateTime.Now.ToString("HH:mm:ss tt");

       int i = Add(10, 10);
       Console.WriteLine(test);
       global::System.Console.WriteLine(i);
       Thread.Sleep(1000);
       new Thread(() =>
       {
           string test = DateTime.Now.ToString("HH:mm:ss tt");

           int i = Add(20, 20);
           Console.WriteLine(test);
           global::System.Console.WriteLine(i);
           Thread.Sleep(1000);
           Console.WriteLine(test);
           Thread.Sleep(1000);
           Console.WriteLine(test);
           Thread.Sleep(1000);
           Console.WriteLine(test);
           Thread.Sleep(1000);

       }).Start();

   }).Start();


}).Start();

new Thread(() =>
{
   string test = DateTime.Now.ToString("HH:mm:ss tt");
   int i = Add(5, 5);
   Console.WriteLine(test);
   global::System.Console.WriteLine(i);
   Thread.Sleep(1000);

   new Thread(() =>
   {
       string test = DateTime.Now.ToString("HH:mm:ss tt");

       int i = Add(10, 10);
       Console.WriteLine(test);
       global::System.Console.WriteLine(i);
       Thread.Sleep(1000);
       new Thread(() =>
       {
           string test = DateTime.Now.ToString("HH:mm:ss tt");

           int i = Add(20, 20);
           Console.WriteLine(test);
           global::System.Console.WriteLine(i);
           Thread.Sleep(1000);
           Console.WriteLine(test);
           Thread.Sleep(1000);
           Console.WriteLine(test);
           Thread.Sleep(1000);
           Console.WriteLine(test);
           Thread.Sleep(1000);

       }).Start();

   }).Start();

}).Start();

new Thread(() =>
{
   string test = DateTime.Now.ToString("HH:mm:ss tt");
   int i = Add(5, 5);
   Console.WriteLine(test);
   global::System.Console.WriteLine(i);
   Thread.Sleep(1000);

   new Thread(() =>
   {
       string test = DateTime.Now.ToString("HH:mm:ss tt");

       int i = Add(10, 10);
       Console.WriteLine(test);
       global::System.Console.WriteLine(i);
       Thread.Sleep(1000);
       new Thread(() =>
       {
           string test = DateTime.Now.ToString("HH:mm:ss tt");

           int i = Add(20, 20);
           Console.WriteLine(test);
           global::System.Console.WriteLine(i);
           Thread.Sleep(1000);
           Console.WriteLine(test);
           Thread.Sleep(1000);
           Console.WriteLine(test);
           Thread.Sleep(1000);
           Console.WriteLine(test);
           Thread.Sleep(1000);

       }).Start();


   }).Start();

}).Start();



Console.Read();

int Add(int a, int b) { return a + b; }
*/

/* var taskCompletionSource = new TaskCompletionSource<bool>();

var thread = new Thread(() => 
{
    string test = DateTime.Now.ToString("HH:mm:ss tt");
    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
    Thread.Sleep(5000);
    taskCompletionSource.TrySetResult(true);
    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
});

thread.Start();

var test = taskCompletionSource.Task.Result;
Console.WriteLine($"Task was complete: {test}");
Console.ReadLine();
*/

//this new thread is running in the background
new Thread(() =>
{
Console.WriteLine($"Thread 4");

})
{ IsBackground = true }.Start();
//Creates 100 total threads 
Enumerable.Range(0, 100).ToList().ForEach(f =>
 {
     ThreadPool.QueueUserWorkItem((o) =>
      {
                 Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started.");
                 Thread.Sleep(1000);
                 Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended.");
       });

 });





Console.ReadLine();