namespace AsyncAwaitClosure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool closure = false;

            for (int i = 0; i < 1000; i++)
            {
                int captureValue = i;

                ThreadPool.QueueUserWorkItem(delegate
                {
                    if (closure)
                    {
                        Console.WriteLine(captureValue);
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                    Thread.Sleep(1000);
                });
            }
            Console.ReadLine();
        }
    }
}
