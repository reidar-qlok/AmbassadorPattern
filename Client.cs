namespace AmbassadorPattern
{
    public class Client
    {
        private readonly IServiceAmbassador _ambassador;

        public Client(IServiceAmbassador ambassador)
        {
            _ambassador = ambassador;
        }

        public void DoSomething()
        {
            Console.WriteLine("Client is doing something...");
            // Perform some actions
            _ambassador.DoSomething();
            // Continue with other actions
            Console.WriteLine("Client finished doing something.");
        }
    }
}
