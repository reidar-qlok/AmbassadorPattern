/*
 In this example, the Client interacts with the Service through the ServiceAmbassador. 
The ServiceAmbassador implements the IServiceAmbassador interface, which acts as a mediator 
between the client and the actual service implementation. It handles any necessary adaptations 
or transformations and then delegates the task to the Service.
 */
namespace AmbassadorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IService service = new SomeService();
            IServiceAmbassador ambassador = new ServiceAmbassador(service);
            Client client = new Client(ambassador);

            client.DoSomething();
        }
    }
}