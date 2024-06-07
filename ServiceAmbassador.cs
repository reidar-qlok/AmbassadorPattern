namespace AmbassadorPattern
{
    public class ServiceAmbassador : IServiceAmbassador
    {
        private readonly IService _service;
        private const int RetryCount = 3;
        private const int RetryDelay = 4000; // milliseconds

        public ServiceAmbassador(IService service)
        {
            _service = service;
        }

        public void DoSomething()
        {
            int attempts = 0;
            bool success = false;

            while (attempts < RetryCount && !success)
            {
                try
                {
                    Console.WriteLine($"ServiceAmbassador: Attempt {attempts + 1}");
                    _service.DoSomething();
                    success = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ServiceAmbassador: Exception caught: {ex.Message}");
                    attempts++;
                    if (attempts < RetryCount)
                    {
                        Console.WriteLine("ServiceAmbassador: Retrying in please wait...");
                        Thread.Sleep(RetryDelay);
                    }
                    else
                    {
                        Console.WriteLine("ServiceAmbassador: All retry attempts failed.");
                    }
                }
            }
        }
    }
}
