namespace AmbassadorPattern
{
    public class SomeService : IService
    {
        private static readonly Random Random = new Random();

        public void DoSomething()
        {
            // Simulate a service that occasionally fails
            if (Random.Next(1, 10) <= 3) // 30% chance of failure
            {
                throw new Exception("Service failure!");
            }
            Console.WriteLine("SomeService: Doing something successfully.");
        }
    }
}
